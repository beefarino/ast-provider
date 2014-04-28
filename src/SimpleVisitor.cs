using System.Management.Automation.Language;

namespace AstProvider
{
    class SimpleVisitor : AstVisitor
    {
        private readonly AstPathNodeBase _collector;

        public SimpleVisitor( AstPathNodeBase ast)
        {
            _collector = ast;
        }

        private bool _first = true;
        AstVisitAction DoNextAction(Ast ast) 
        {
            if (_first)
            {
                _first = false;
                return AstVisitAction.Continue;
            }
            _collector.AddChild(ast);
            return AstVisitAction.SkipChildren;
        }

        public override AstVisitAction VisitErrorStatement(ErrorStatementAst ast)
        {

            return DoNextAction(ast);
        }

        public override AstVisitAction VisitErrorExpression(ErrorExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitScriptBlock(ScriptBlockAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitParamBlock(ParamBlockAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitNamedBlock(NamedBlockAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitTypeConstraint(TypeConstraintAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitAttribute(AttributeAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitParameter(ParameterAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitTypeExpression(TypeExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitFunctionDefinition(FunctionDefinitionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitStatementBlock(StatementBlockAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitIfStatement(IfStatementAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitTrap(TrapStatementAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitSwitchStatement(SwitchStatementAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitDataStatement(DataStatementAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitForEachStatement(ForEachStatementAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitDoWhileStatement(DoWhileStatementAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitForStatement(ForStatementAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitWhileStatement(WhileStatementAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitCatchClause(CatchClauseAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitTryStatement(TryStatementAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitBreakStatement(BreakStatementAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitContinueStatement(ContinueStatementAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitReturnStatement(ReturnStatementAst ast)
        {
            return DoNextAction(ast);
        }
        public override AstVisitAction VisitExitStatement(ExitStatementAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitThrowStatement(ThrowStatementAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitDoUntilStatement(DoUntilStatementAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitAssignmentStatement(AssignmentStatementAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitPipeline(PipelineAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitCommand(CommandAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitCommandExpression(CommandExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitCommandParameter(CommandParameterAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitMergingRedirection(MergingRedirectionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitFileRedirection(FileRedirectionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitBinaryExpression(BinaryExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitUnaryExpression(UnaryExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitConvertExpression(ConvertExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitConstantExpression(ConstantExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitStringConstantExpression(StringConstantExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitSubExpression(SubExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitUsingExpression(UsingExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitVariableExpression(VariableExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitMemberExpression(MemberExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitInvokeMemberExpression(InvokeMemberExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitArrayExpression(ArrayExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitArrayLiteral(ArrayLiteralAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitHashtable(HashtableAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitScriptBlockExpression(ScriptBlockExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitParenExpression(ParenExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitExpandableStringExpression(ExpandableStringExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitIndexExpression(IndexExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitAttributedExpression(AttributedExpressionAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitBlockStatement(BlockStatementAst ast)
        {
            return DoNextAction(ast);
        }

        public override AstVisitAction VisitNamedAttributeArgument(NamedAttributeArgumentAst ast)
        {
            return DoNextAction(ast);
        }
    }
}