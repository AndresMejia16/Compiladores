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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="AnalizadorParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IAnalizadorListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AnalizadorParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] AnalizadorParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnalizadorParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] AnalizadorParser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AnalizadorParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpresion([NotNull] AnalizadorParser.ExpresionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnalizadorParser.expresion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpresion([NotNull] AnalizadorParser.ExpresionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AnalizadorParser.dec_var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDec_var([NotNull] AnalizadorParser.Dec_varContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnalizadorParser.dec_var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDec_var([NotNull] AnalizadorParser.Dec_varContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AnalizadorParser.asing_var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAsing_var([NotNull] AnalizadorParser.Asing_varContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnalizadorParser.asing_var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAsing_var([NotNull] AnalizadorParser.Asing_varContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AnalizadorParser.dec_asing_var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDec_asing_var([NotNull] AnalizadorParser.Dec_asing_varContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnalizadorParser.dec_asing_var"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDec_asing_var([NotNull] AnalizadorParser.Dec_asing_varContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AnalizadorParser.ops"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOps([NotNull] AnalizadorParser.OpsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnalizadorParser.ops"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOps([NotNull] AnalizadorParser.OpsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AnalizadorParser.ops_variables"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOps_variables([NotNull] AnalizadorParser.Ops_variablesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnalizadorParser.ops_variables"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOps_variables([NotNull] AnalizadorParser.Ops_variablesContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="AnalizadorParser.println"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrintln([NotNull] AnalizadorParser.PrintlnContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AnalizadorParser.println"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrintln([NotNull] AnalizadorParser.PrintlnContext context);
}
} // namespace Compilador
