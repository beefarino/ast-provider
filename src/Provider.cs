using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Automation.Language;
using System.Management.Automation.Provider;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Management.Automation;
using CodeOwls.PowerShell.Paths;
using CodeOwls.PowerShell.Paths.Processors;
using CodeOwls.PowerShell.Provider;
using CodeOwls.PowerShell.Provider.PathNodes;

namespace AstProvider
{
    [CmdletProvider("AST", ProviderCapabilities.ShouldProcess)]
    public class AstProvider : Provider
    {
        protected override IPathResolver PathResolver
        {
            get
            {
                return new AstPathResolver();
            }
        }
    }


    public class AstPathResolver : PathResolverBase
    {
        private string _script;
        private ScriptBlockAst _ast;

        public AstPathResolver()
        {
            
        }

        public override IEnumerable<IPathNode> ResolvePath(CodeOwls.PowerShell.Provider.PathNodeProcessors.IProviderContext providerContext, string path)
        {
            if (null == _script)
            {
                var script = Regex.Replace( path, @"^(.+?\.ps1).*$", "$1");
                _script = script;

                Token[] _tokens;
                ParseError[] _errors;
                _ast = Parser.ParseFile(_script, out _tokens, out _errors);
            }
            path = path.Replace(_script, String.Empty);
            return base.ResolvePath(providerContext, path);
        }
        protected override IPathNode Root
        {
            get { return new AstPathNode(_ast, 0); }
        }
    }

    abstract public class AstPathNodeBase : PathNodeBase
    {

        
        private readonly List<Ast> _children = new List<Ast>(); 
        public void AddChild(Ast childAst)
        {
            _children.Add( childAst );
        }

        protected List<Ast> Children
        {
            get { return _children; }
        }

    }
       
    public class AstPathNode : AstPathNodeBase
    {
        private readonly Ast _ast;
        private readonly int _index;

        public AstPathNode(string script)
        {
            _index = 0;
            Token[] _tokens;
            ParseError[] _errors;
            _ast = Parser.ParseInput(script, out _tokens, out _errors);
        }

        public AstPathNode(Ast ast, int index)
        {
            _ast = ast;
            _index = index;
        }

        public override IPathValue GetNodeValue()
        {
            var pso = PSObject.AsPSObject(_ast);
            pso.Properties.Add( new PSNoteProperty("AstType", _ast.GetType().Name));
            return new ContainerPathValue( _ast, Name);
        }

        public override string Name
        {
            get { return "AstNode" + _index.ToString(); }
        }

        public override IEnumerable<IPathNode> GetNodeChildren(CodeOwls.PowerShell.Provider.PathNodeProcessors.IProviderContext providerContext)
        {
            var index = 0;
            Children.Clear();
            var visitor = new SimpleVisitor(this);
            _ast.Visit(visitor);
            return from child in Children 
                   select new AstPathNode(child, ++index);
        }
    }
}
