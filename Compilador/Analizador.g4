grammar Analizador;

@parser::members
{
    protected const int EOF = Eof;
}
@lexer::members
{
    protected const int EOF = Eof;
    protected const int HIDDEN = Hidden;
}
/*
 * Parser Rules
 */

/*DEFINIENDO LA ESTRUCTURA DE NUESTRO PROGRAMA.*/

/* GRAMATICA LIBRE DE CONTEXTO */

/*
* En este gramatica vamos a soportar por el momento
* La declaracion de variables, asignacion de valores e impresion por pantalla.
*/

/* Nuestro programa tendra una estructura basica.
*   program IDENTIFICADOR
*   {
*		SENTENCIAS
*	}
*/
program : PROGRAM IDENTIFIER 
			LLAV_A 
				expresion+ 
			LLAV_C;

//Una expresion o sentencia en este caso se compone de una declaracion de variable, 
//o de una asignacion de variable, o de una operacion matematica o una impresion por pantalla.
expresion : dec_var | asing_var | dec_asing_var | println	;


//Una declaracion de variable esta compuesta por. VAR IDENTIFICADOR ;
dec_var : VAR IDENTIFIER SEMICOLON |
		  INT IDENTIFIER SEMICOLON;



asing_var : IDENTIFIER ASSIGN INTEGERS SEMICOLON	|
			 IDENTIFIER ASSIGN STRING SEMICOLON |
			IDENTIFIER ASSIGN ops |
			IDENTIFIER ASSIGN ops_variables ;

dec_asing_var : VAR IDENTIFIER ASSIGN INTEGERS SEMICOLON |
				  VAR IDENTIFIER ASSIGN ops |
				  VAR IDENTIFIER ASSIGN STRING SEMICOLON |
				  INT IDENTIFIER ASSIGN INTEGERS SEMICOLON |
				  INT IDENTIFIER ASSIGN ops;

ops : INTEGERS PROD INTEGERS SEMICOLON|
	  INTEGERS PLUS INTEGERS SEMICOLON |
	  INTEGERS SUB INTEGERS  SEMICOLON|
	  INTEGERS DIV INTEGERS SEMICOLON |
      ;

ops_variables : IDENTIFIER PROD IDENTIFIER SEMICOLON|
	  IDENTIFIER PLUS IDENTIFIER SEMICOLON |
	  IDENTIFIER SUB IDENTIFIER  SEMICOLON|
	  IDENTIFIER DIV IDENTIFIER SEMICOLON;

println : PRINT IDENTIFIER SEMICOLON;


/*
 * Lexer Rules
 */

//Palabras reservadas.
ACCESSM : ('public' | 'private' | 'protected');
PROGRAM : 'program';
VAR : 'var';
INT : 'int';
PRINT : 'print';
//Operadores
PLUS : '+';
SUBS : '-';
PROD: '*';
DIV: '/';
//Operadores logicos
AND : '&&';
OR : '||';
NOT : '!';
//Comparadores
GT : '>';
LT : '<';
GEQ : '>=';
LEG : '<=';
EQ : '==';
NEQ : '!=';
//Asignacion
ASSIGN : '=';
// llaves, corchetes y parentesis
PAREN_A : '(';
PAREN_C : ')';
LLAV_A : '{';
LLAV_C : '}';
CORCH_A : '[';
CORCH_C : ']';
//Identificadores
IDENTIFIER : ('a'..'z'|'A'..'Z'|'_') ('a'..'z'|'A'..'Z'|'0'..'9'|'_')*;
//Enteros
INTEGERS : [0-9]+;
//Punto y coma
SEMICOLON : ';';
STRING
    :  '"' ( ESC_SEQ | ~('\\'|'"') )* '"'
    ;

CHAR:  '\'' ( ESC_SEQ | ~('\''|'\\') ) '\''
    ;
ESC_SEQ
    :   '\\' ('b'|'t'|'n'|'f'|'r'|'\"'|'\''|'\\')
    ;
//Simbolos considerados desconocidos.
Unknown : '[<{|]'+ 
			|'^'|'´'|'~'|'`'|'?'+|'¿'+|[¿?]+[?¿]+|'¨'+|[a_z¿?]+|[¿?a_z]+;
//Obviamos la tabulacion, salto de linea y espacios.
WS:	[\t\n\r] -> skip;