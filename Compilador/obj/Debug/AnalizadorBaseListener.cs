﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\jefe.registro.USBMED\Desktop\Compilador (2)\Compilador\Analizador.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Compilador {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IAnalizadorListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class AnalizadorBaseListener : IAnalizadorListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AnalizadorParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] AnalizadorParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnalizadorParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] AnalizadorParser.ProgramContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AnalizadorParser.expresion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpresion([NotNull] AnalizadorParser.ExpresionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnalizadorParser.expresion"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpresion([NotNull] AnalizadorParser.ExpresionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AnalizadorParser.dec_var"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDec_var([NotNull] AnalizadorParser.Dec_varContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnalizadorParser.dec_var"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDec_var([NotNull] AnalizadorParser.Dec_varContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AnalizadorParser.asing_var"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsing_var([NotNull] AnalizadorParser.Asing_varContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnalizadorParser.asing_var"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsing_var([NotNull] AnalizadorParser.Asing_varContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AnalizadorParser.dec_asing_var"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDec_asing_var([NotNull] AnalizadorParser.Dec_asing_varContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnalizadorParser.dec_asing_var"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDec_asing_var([NotNull] AnalizadorParser.Dec_asing_varContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AnalizadorParser.ops"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOps([NotNull] AnalizadorParser.OpsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnalizadorParser.ops"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOps([NotNull] AnalizadorParser.OpsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AnalizadorParser.ops_variables"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOps_variables([NotNull] AnalizadorParser.Ops_variablesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnalizadorParser.ops_variables"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOps_variables([NotNull] AnalizadorParser.Ops_variablesContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="AnalizadorParser.println"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPrintln([NotNull] AnalizadorParser.PrintlnContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnalizadorParser.println"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPrintln([NotNull] AnalizadorParser.PrintlnContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Compilador