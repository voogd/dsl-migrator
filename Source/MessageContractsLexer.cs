//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4.1.9004
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4.1.9004 MessageContracts.g 2019-03-14 19:50:06

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;

namespace  MessageContracts 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4.1.9004")]
[System.CLSCompliant(false)]
public partial class MessageContractsLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int ARRAY=4;
	public const int ASYNC=5;
	public const int BlockToken=6;
	public const int COMMENT=7;
	public const int CONST=8;
	public const int CommandToken=9;
	public const int DisctionaryToken=10;
	public const int ESC_SEQ=11;
	public const int EXPLICIT=12;
	public const int EXTERN=13;
	public const int EntityDefinition=14;
	public const int EventToken=15;
	public const int ExternToken=16;
	public const int FragmentEntry=17;
	public const int FragmentGroup=18;
	public const int FragmentReference=19;
	public const int HEX_DIGIT=20;
	public const int ID=21;
	public const int IF=22;
	public const int INT=23;
	public const int INTERFACE=24;
	public const int MemberToken=25;
	public const int Modifier=26;
	public const int ModifierDefinition=27;
	public const int NAMESPACE=28;
	public const int NamespaceToken=29;
	public const int OCTAL_ESC=30;
	public const int STRING=31;
	public const int StringRepresentationToken=32;
	public const int Sync=33;
	public const int TypeToken=34;
	public const int UNICODE_ESC=35;
	public const int USING=36;
	public const int UsingToken=37;
	public const int WS=38;
	public const int T__39=39;
	public const int T__40=40;
	public const int T__41=41;
	public const int T__42=42;
	public const int T__43=43;
	public const int T__44=44;
	public const int T__45=45;
	public const int T__46=46;

    // delegates
    // delegators

	public MessageContractsLexer()
	{
		OnCreated();
	}

	public MessageContractsLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public MessageContractsLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
	public override string GrammarFileName { get { return "MessageContracts.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void EnterRule_T__39();
	partial void LeaveRule_T__39();

	// $ANTLR start "T__39"
	[GrammarRule("T__39")]
	private void mT__39()
	{
		EnterRule_T__39();
		EnterRule("T__39", 1);
		TraceIn("T__39", 1);
		try
		{
			int _type = T__39;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:9:7: ( '(' )
			DebugEnterAlt(1);
			// MessageContracts.g:9:9: '('
			{
			DebugLocation(9, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__39", 1);
			LeaveRule("T__39", 1);
			LeaveRule_T__39();
		}
	}
	// $ANTLR end "T__39"

	partial void EnterRule_T__40();
	partial void LeaveRule_T__40();

	// $ANTLR start "T__40"
	[GrammarRule("T__40")]
	private void mT__40()
	{
		EnterRule_T__40();
		EnterRule("T__40", 2);
		TraceIn("T__40", 2);
		try
		{
			int _type = T__40;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:10:7: ( ')' )
			DebugEnterAlt(1);
			// MessageContracts.g:10:9: ')'
			{
			DebugLocation(10, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__40", 2);
			LeaveRule("T__40", 2);
			LeaveRule_T__40();
		}
	}
	// $ANTLR end "T__40"

	partial void EnterRule_T__41();
	partial void LeaveRule_T__41();

	// $ANTLR start "T__41"
	[GrammarRule("T__41")]
	private void mT__41()
	{
		EnterRule_T__41();
		EnterRule("T__41", 3);
		TraceIn("T__41", 3);
		try
		{
			int _type = T__41;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:11:7: ( ',' )
			DebugEnterAlt(1);
			// MessageContracts.g:11:9: ','
			{
			DebugLocation(11, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__41", 3);
			LeaveRule("T__41", 3);
			LeaveRule_T__41();
		}
	}
	// $ANTLR end "T__41"

	partial void EnterRule_T__42();
	partial void LeaveRule_T__42();

	// $ANTLR start "T__42"
	[GrammarRule("T__42")]
	private void mT__42()
	{
		EnterRule_T__42();
		EnterRule("T__42", 4);
		TraceIn("T__42", 4);
		try
		{
			int _type = T__42;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:12:7: ( '.' )
			DebugEnterAlt(1);
			// MessageContracts.g:12:9: '.'
			{
			DebugLocation(12, 9);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__42", 4);
			LeaveRule("T__42", 4);
			LeaveRule_T__42();
		}
	}
	// $ANTLR end "T__42"

	partial void EnterRule_T__43();
	partial void LeaveRule_T__43();

	// $ANTLR start "T__43"
	[GrammarRule("T__43")]
	private void mT__43()
	{
		EnterRule_T__43();
		EnterRule("T__43", 5);
		TraceIn("T__43", 5);
		try
		{
			int _type = T__43;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:13:7: ( ';' )
			DebugEnterAlt(1);
			// MessageContracts.g:13:9: ';'
			{
			DebugLocation(13, 9);
			Match(';'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__43", 5);
			LeaveRule("T__43", 5);
			LeaveRule_T__43();
		}
	}
	// $ANTLR end "T__43"

	partial void EnterRule_T__44();
	partial void LeaveRule_T__44();

	// $ANTLR start "T__44"
	[GrammarRule("T__44")]
	private void mT__44()
	{
		EnterRule_T__44();
		EnterRule("T__44", 6);
		TraceIn("T__44", 6);
		try
		{
			int _type = T__44;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:14:7: ( '=' )
			DebugEnterAlt(1);
			// MessageContracts.g:14:9: '='
			{
			DebugLocation(14, 9);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__44", 6);
			LeaveRule("T__44", 6);
			LeaveRule_T__44();
		}
	}
	// $ANTLR end "T__44"

	partial void EnterRule_T__45();
	partial void LeaveRule_T__45();

	// $ANTLR start "T__45"
	[GrammarRule("T__45")]
	private void mT__45()
	{
		EnterRule_T__45();
		EnterRule("T__45", 7);
		TraceIn("T__45", 7);
		try
		{
			int _type = T__45;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:15:7: ( '{' )
			DebugEnterAlt(1);
			// MessageContracts.g:15:9: '{'
			{
			DebugLocation(15, 9);
			Match('{'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__45", 7);
			LeaveRule("T__45", 7);
			LeaveRule_T__45();
		}
	}
	// $ANTLR end "T__45"

	partial void EnterRule_T__46();
	partial void LeaveRule_T__46();

	// $ANTLR start "T__46"
	[GrammarRule("T__46")]
	private void mT__46()
	{
		EnterRule_T__46();
		EnterRule("T__46", 8);
		TraceIn("T__46", 8);
		try
		{
			int _type = T__46;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:16:7: ( '}' )
			DebugEnterAlt(1);
			// MessageContracts.g:16:9: '}'
			{
			DebugLocation(16, 9);
			Match('}'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__46", 8);
			LeaveRule("T__46", 8);
			LeaveRule_T__46();
		}
	}
	// $ANTLR end "T__46"

	partial void EnterRule_EXPLICIT();
	partial void LeaveRule_EXPLICIT();

	// $ANTLR start "EXPLICIT"
	[GrammarRule("EXPLICIT")]
	private void mEXPLICIT()
	{
		EnterRule_EXPLICIT();
		EnterRule("EXPLICIT", 9);
		TraceIn("EXPLICIT", 9);
		try
		{
			int _type = EXPLICIT;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:88:2: ( 'explicit' )
			DebugEnterAlt(1);
			// MessageContracts.g:88:4: 'explicit'
			{
			DebugLocation(88, 4);
			Match("explicit"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EXPLICIT", 9);
			LeaveRule("EXPLICIT", 9);
			LeaveRule_EXPLICIT();
		}
	}
	// $ANTLR end "EXPLICIT"

	partial void EnterRule_IF();
	partial void LeaveRule_IF();

	// $ANTLR start "IF"
	[GrammarRule("IF")]
	private void mIF()
	{
		EnterRule_IF();
		EnterRule("IF", 10);
		TraceIn("IF", 10);
		try
		{
			int _type = IF;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:90:2: ( 'if' )
			DebugEnterAlt(1);
			// MessageContracts.g:90:4: 'if'
			{
			DebugLocation(90, 4);
			Match("if"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IF", 10);
			LeaveRule("IF", 10);
			LeaveRule_IF();
		}
	}
	// $ANTLR end "IF"

	partial void EnterRule_USING();
	partial void LeaveRule_USING();

	// $ANTLR start "USING"
	[GrammarRule("USING")]
	private void mUSING()
	{
		EnterRule_USING();
		EnterRule("USING", 11);
		TraceIn("USING", 11);
		try
		{
			int _type = USING;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:92:5: ( 'using' )
			DebugEnterAlt(1);
			// MessageContracts.g:92:7: 'using'
			{
			DebugLocation(92, 7);
			Match("using"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("USING", 11);
			LeaveRule("USING", 11);
			LeaveRule_USING();
		}
	}
	// $ANTLR end "USING"

	partial void EnterRule_CONST();
	partial void LeaveRule_CONST();

	// $ANTLR start "CONST"
	[GrammarRule("CONST")]
	private void mCONST()
	{
		EnterRule_CONST();
		EnterRule("CONST", 12);
		TraceIn("CONST", 12);
		try
		{
			int _type = CONST;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:94:2: ( 'const' )
			DebugEnterAlt(1);
			// MessageContracts.g:94:4: 'const'
			{
			DebugLocation(94, 4);
			Match("const"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CONST", 12);
			LeaveRule("CONST", 12);
			LeaveRule_CONST();
		}
	}
	// $ANTLR end "CONST"

	partial void EnterRule_INTERFACE();
	partial void LeaveRule_INTERFACE();

	// $ANTLR start "INTERFACE"
	[GrammarRule("INTERFACE")]
	private void mINTERFACE()
	{
		EnterRule_INTERFACE();
		EnterRule("INTERFACE", 13);
		TraceIn("INTERFACE", 13);
		try
		{
			int _type = INTERFACE;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:96:2: ( 'interface' )
			DebugEnterAlt(1);
			// MessageContracts.g:96:4: 'interface'
			{
			DebugLocation(96, 4);
			Match("interface"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INTERFACE", 13);
			LeaveRule("INTERFACE", 13);
			LeaveRule_INTERFACE();
		}
	}
	// $ANTLR end "INTERFACE"

	partial void EnterRule_NAMESPACE();
	partial void LeaveRule_NAMESPACE();

	// $ANTLR start "NAMESPACE"
	[GrammarRule("NAMESPACE")]
	private void mNAMESPACE()
	{
		EnterRule_NAMESPACE();
		EnterRule("NAMESPACE", 14);
		TraceIn("NAMESPACE", 14);
		try
		{
			int _type = NAMESPACE;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:98:2: ( 'namespace' )
			DebugEnterAlt(1);
			// MessageContracts.g:98:4: 'namespace'
			{
			DebugLocation(98, 4);
			Match("namespace"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NAMESPACE", 14);
			LeaveRule("NAMESPACE", 14);
			LeaveRule_NAMESPACE();
		}
	}
	// $ANTLR end "NAMESPACE"

	partial void EnterRule_EXTERN();
	partial void LeaveRule_EXTERN();

	// $ANTLR start "EXTERN"
	[GrammarRule("EXTERN")]
	private void mEXTERN()
	{
		EnterRule_EXTERN();
		EnterRule("EXTERN", 15);
		TraceIn("EXTERN", 15);
		try
		{
			int _type = EXTERN;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:100:5: ( 'extern' )
			DebugEnterAlt(1);
			// MessageContracts.g:100:7: 'extern'
			{
			DebugLocation(100, 7);
			Match("extern"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EXTERN", 15);
			LeaveRule("EXTERN", 15);
			LeaveRule_EXTERN();
		}
	}
	// $ANTLR end "EXTERN"

	partial void EnterRule_ASYNC();
	partial void LeaveRule_ASYNC();

	// $ANTLR start "ASYNC"
	[GrammarRule("ASYNC")]
	private void mASYNC()
	{
		EnterRule_ASYNC();
		EnterRule("ASYNC", 16);
		TraceIn("ASYNC", 16);
		try
		{
			int _type = ASYNC;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:102:2: ( 'async' )
			DebugEnterAlt(1);
			// MessageContracts.g:102:4: 'async'
			{
			DebugLocation(102, 4);
			Match("async"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASYNC", 16);
			LeaveRule("ASYNC", 16);
			LeaveRule_ASYNC();
		}
	}
	// $ANTLR end "ASYNC"

	partial void EnterRule_ID();
	partial void LeaveRule_ID();

	// $ANTLR start "ID"
	[GrammarRule("ID")]
	private void mID()
	{
		EnterRule_ID();
		EnterRule("ID", 17);
		TraceIn("ID", 17);
		try
		{
			int _type = ID;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:104:5: ( ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '<' | '>' | '[' | ']' )* )
			DebugEnterAlt(1);
			// MessageContracts.g:104:7: ( 'a' .. 'z' | 'A' .. 'Z' | '_' ) ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '<' | '>' | '[' | ']' )*
			{
			DebugLocation(104, 7);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}

			DebugLocation(104, 30);
			// MessageContracts.g:104:30: ( 'a' .. 'z' | 'A' .. 'Z' | '0' .. '9' | '_' | '<' | '>' | '[' | ']' )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, false);
				int LA1_1 = input.LA(1);

				if (((LA1_1>='0' && LA1_1<='9')||LA1_1=='<'||LA1_1=='>'||(LA1_1>='A' && LA1_1<='[')||LA1_1==']'||LA1_1=='_'||(LA1_1>='a' && LA1_1<='z')))
				{
					alt1 = 1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// MessageContracts.g:
					{
					DebugLocation(104, 30);
					input.Consume();


					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ID", 17);
			LeaveRule("ID", 17);
			LeaveRule_ID();
		}
	}
	// $ANTLR end "ID"

	partial void EnterRule_Modifier();
	partial void LeaveRule_Modifier();

	// $ANTLR start "Modifier"
	[GrammarRule("Modifier")]
	private void mModifier()
	{
		EnterRule_Modifier();
		EnterRule("Modifier", 18);
		TraceIn("Modifier", 18);
		try
		{
			int _type = Modifier;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:108:2: ( '?' | '!' | ';' )
			DebugEnterAlt(1);
			// MessageContracts.g:
			{
			DebugLocation(108, 2);
			if (input.LA(1)=='!'||input.LA(1)==';'||input.LA(1)=='?')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("Modifier", 18);
			LeaveRule("Modifier", 18);
			LeaveRule_Modifier();
		}
	}
	// $ANTLR end "Modifier"

	partial void EnterRule_INT();
	partial void LeaveRule_INT();

	// $ANTLR start "INT"
	[GrammarRule("INT")]
	private void mINT()
	{
		EnterRule_INT();
		EnterRule("INT", 19);
		TraceIn("INT", 19);
		try
		{
			int _type = INT;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:114:5: ( ( '0' .. '9' )+ )
			DebugEnterAlt(1);
			// MessageContracts.g:114:7: ( '0' .. '9' )+
			{
			DebugLocation(114, 7);
			// MessageContracts.g:114:7: ( '0' .. '9' )+
			int cnt2=0;
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, false);
				int LA2_1 = input.LA(1);

				if (((LA2_1>='0' && LA2_1<='9')))
				{
					alt2 = 1;
				}


				} finally { DebugExitDecision(2); }
				switch (alt2)
				{
				case 1:
					DebugEnterAlt(1);
					// MessageContracts.g:
					{
					DebugLocation(114, 7);
					input.Consume();


					}
					break;

				default:
					if (cnt2 >= 1)
						goto loop2;

					EarlyExitException eee2 = new EarlyExitException( 2, input );
					DebugRecognitionException(eee2);
					throw eee2;
				}
				cnt2++;
			}
			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("INT", 19);
			LeaveRule("INT", 19);
			LeaveRule_INT();
		}
	}
	// $ANTLR end "INT"

	partial void EnterRule_ARRAY();
	partial void LeaveRule_ARRAY();

	// $ANTLR start "ARRAY"
	[GrammarRule("ARRAY")]
	private void mARRAY()
	{
		EnterRule_ARRAY();
		EnterRule("ARRAY", 20);
		TraceIn("ARRAY", 20);
		try
		{
			int _type = ARRAY;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:116:7: ( '[]' )
			DebugEnterAlt(1);
			// MessageContracts.g:116:9: '[]'
			{
			DebugLocation(116, 9);
			Match("[]"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ARRAY", 20);
			LeaveRule("ARRAY", 20);
			LeaveRule_ARRAY();
		}
	}
	// $ANTLR end "ARRAY"

	partial void EnterRule_STRING();
	partial void LeaveRule_STRING();

	// $ANTLR start "STRING"
	[GrammarRule("STRING")]
	private void mSTRING()
	{
		EnterRule_STRING();
		EnterRule("STRING", 21);
		TraceIn("STRING", 21);
		try
		{
			int _type = STRING;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:119:5: ( '\"' ( ESC_SEQ |~ ( '\\\\' | '\"' ) )* '\"' )
			DebugEnterAlt(1);
			// MessageContracts.g:119:8: '\"' ( ESC_SEQ |~ ( '\\\\' | '\"' ) )* '\"'
			{
			DebugLocation(119, 8);
			Match('\"'); 
			DebugLocation(119, 12);
			// MessageContracts.g:119:12: ( ESC_SEQ |~ ( '\\\\' | '\"' ) )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=3;
				try { DebugEnterDecision(3, false);
				int LA3_1 = input.LA(1);

				if ((LA3_1=='\\'))
				{
					alt3 = 1;
				}
				else if (((LA3_1>='\u0000' && LA3_1<='!')||(LA3_1>='#' && LA3_1<='[')||(LA3_1>=']' && LA3_1<='\uFFFF')))
				{
					alt3 = 2;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// MessageContracts.g:119:14: ESC_SEQ
					{
					DebugLocation(119, 14);
					mESC_SEQ(); 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// MessageContracts.g:119:24: ~ ( '\\\\' | '\"' )
					{
					DebugLocation(119, 24);
					input.Consume();


					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }

			DebugLocation(119, 39);
			Match('\"'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("STRING", 21);
			LeaveRule("STRING", 21);
			LeaveRule_STRING();
		}
	}
	// $ANTLR end "STRING"

	partial void EnterRule_HEX_DIGIT();
	partial void LeaveRule_HEX_DIGIT();

	// $ANTLR start "HEX_DIGIT"
	[GrammarRule("HEX_DIGIT")]
	private void mHEX_DIGIT()
	{
		EnterRule_HEX_DIGIT();
		EnterRule("HEX_DIGIT", 22);
		TraceIn("HEX_DIGIT", 22);
		try
		{
			// MessageContracts.g:125:11: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
			DebugEnterAlt(1);
			// MessageContracts.g:
			{
			DebugLocation(125, 11);
			if ((input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='F')||(input.LA(1)>='a' && input.LA(1)<='f'))
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}


			}

		}
		finally
		{
			TraceOut("HEX_DIGIT", 22);
			LeaveRule("HEX_DIGIT", 22);
			LeaveRule_HEX_DIGIT();
		}
	}
	// $ANTLR end "HEX_DIGIT"

	partial void EnterRule_ESC_SEQ();
	partial void LeaveRule_ESC_SEQ();

	// $ANTLR start "ESC_SEQ"
	[GrammarRule("ESC_SEQ")]
	private void mESC_SEQ()
	{
		EnterRule_ESC_SEQ();
		EnterRule("ESC_SEQ", 23);
		TraceIn("ESC_SEQ", 23);
		try
		{
			// MessageContracts.g:129:5: ( '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' ) | UNICODE_ESC | OCTAL_ESC )
			int alt4=3;
			try { DebugEnterDecision(4, false);
			int LA4_1 = input.LA(1);

			if ((LA4_1=='\\'))
			{
				switch (input.LA(2))
				{
				case '\"':
				case '\'':
				case '\\':
				case 'b':
				case 'f':
				case 'n':
				case 'r':
				case 't':
					{
					alt4 = 1;
					}
					break;
				case 'u':
					{
					alt4 = 2;
					}
					break;
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
					{
					alt4 = 3;
					}
					break;
				default:
					{
						NoViableAltException nvae = new NoViableAltException("", 4, 1, input, 2);
						DebugRecognitionException(nvae);
						throw nvae;
					}
				}

			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 4, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(4); }
			switch (alt4)
			{
			case 1:
				DebugEnterAlt(1);
				// MessageContracts.g:129:9: '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
				{
				DebugLocation(129, 9);
				Match('\\'); 
				DebugLocation(129, 14);
				input.Consume();


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MessageContracts.g:130:9: UNICODE_ESC
				{
				DebugLocation(130, 9);
				mUNICODE_ESC(); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MessageContracts.g:131:9: OCTAL_ESC
				{
				DebugLocation(131, 9);
				mOCTAL_ESC(); 

				}
				break;

			}
		}
		finally
		{
			TraceOut("ESC_SEQ", 23);
			LeaveRule("ESC_SEQ", 23);
			LeaveRule_ESC_SEQ();
		}
	}
	// $ANTLR end "ESC_SEQ"

	partial void EnterRule_OCTAL_ESC();
	partial void LeaveRule_OCTAL_ESC();

	// $ANTLR start "OCTAL_ESC"
	[GrammarRule("OCTAL_ESC")]
	private void mOCTAL_ESC()
	{
		EnterRule_OCTAL_ESC();
		EnterRule("OCTAL_ESC", 24);
		TraceIn("OCTAL_ESC", 24);
		try
		{
			// MessageContracts.g:136:5: ( '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) )
			int alt5=3;
			try { DebugEnterDecision(5, false);
			int LA5_1 = input.LA(1);

			if ((LA5_1=='\\'))
			{
				int LA5_2 = input.LA(2);

				if (((LA5_2>='0' && LA5_2<='3')))
				{
					int LA5_3 = input.LA(3);

					if (((LA5_3>='0' && LA5_3<='7')))
					{
						int LA5_4 = input.LA(4);

						if (((LA5_4>='0' && LA5_4<='7')))
						{
							alt5 = 1;
						}
						else
						{
							alt5 = 2;
						}
					}
					else
					{
						alt5 = 3;
					}
				}
				else if (((LA5_2>='4' && LA5_2<='7')))
				{
					int LA5_3 = input.LA(3);

					if (((LA5_3>='0' && LA5_3<='7')))
					{
						alt5 = 2;
					}
					else
					{
						alt5 = 3;
					}
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 5, 1, input, 2);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 5, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// MessageContracts.g:136:9: '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' )
				{
				DebugLocation(136, 9);
				Match('\\'); 
				DebugLocation(136, 14);
				input.Consume();

				DebugLocation(136, 25);
				input.Consume();

				DebugLocation(136, 36);
				input.Consume();


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MessageContracts.g:137:9: '\\\\' ( '0' .. '7' ) ( '0' .. '7' )
				{
				DebugLocation(137, 9);
				Match('\\'); 
				DebugLocation(137, 14);
				input.Consume();

				DebugLocation(137, 25);
				input.Consume();


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MessageContracts.g:138:9: '\\\\' ( '0' .. '7' )
				{
				DebugLocation(138, 9);
				Match('\\'); 
				DebugLocation(138, 14);
				input.Consume();


				}
				break;

			}
		}
		finally
		{
			TraceOut("OCTAL_ESC", 24);
			LeaveRule("OCTAL_ESC", 24);
			LeaveRule_OCTAL_ESC();
		}
	}
	// $ANTLR end "OCTAL_ESC"

	partial void EnterRule_UNICODE_ESC();
	partial void LeaveRule_UNICODE_ESC();

	// $ANTLR start "UNICODE_ESC"
	[GrammarRule("UNICODE_ESC")]
	private void mUNICODE_ESC()
	{
		EnterRule_UNICODE_ESC();
		EnterRule("UNICODE_ESC", 25);
		TraceIn("UNICODE_ESC", 25);
		try
		{
			// MessageContracts.g:143:5: ( '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT )
			DebugEnterAlt(1);
			// MessageContracts.g:143:9: '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
			{
			DebugLocation(143, 9);
			Match('\\'); 
			DebugLocation(143, 14);
			Match('u'); 
			DebugLocation(143, 18);
			mHEX_DIGIT(); 
			DebugLocation(143, 28);
			mHEX_DIGIT(); 
			DebugLocation(143, 38);
			mHEX_DIGIT(); 
			DebugLocation(143, 48);
			mHEX_DIGIT(); 

			}

		}
		finally
		{
			TraceOut("UNICODE_ESC", 25);
			LeaveRule("UNICODE_ESC", 25);
			LeaveRule_UNICODE_ESC();
		}
	}
	// $ANTLR end "UNICODE_ESC"

	partial void EnterRule_COMMENT();
	partial void LeaveRule_COMMENT();

	// $ANTLR start "COMMENT"
	[GrammarRule("COMMENT")]
	private void mCOMMENT()
	{
		EnterRule_COMMENT();
		EnterRule("COMMENT", 26);
		TraceIn("COMMENT", 26);
		try
		{
			int _type = COMMENT;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:146:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '/*' ( options {greedy=false; } : . )* '*/' )
			int alt9=2;
			try { DebugEnterDecision(9, false);
			int LA9_1 = input.LA(1);

			if ((LA9_1=='/'))
			{
				int LA9_2 = input.LA(2);

				if ((LA9_2=='/'))
				{
					alt9 = 1;
				}
				else if ((LA9_2=='*'))
				{
					alt9 = 2;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 9, 1, input, 2);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 9, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(9); }
			switch (alt9)
			{
			case 1:
				DebugEnterAlt(1);
				// MessageContracts.g:146:9: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
				{
				DebugLocation(146, 9);
				Match("//"); 

				DebugLocation(146, 14);
				// MessageContracts.g:146:14: (~ ( '\\n' | '\\r' ) )*
				try { DebugEnterSubRule(6);
				while (true)
				{
					int alt6=2;
					try { DebugEnterDecision(6, false);
					int LA6_1 = input.LA(1);

					if (((LA6_1>='\u0000' && LA6_1<='\t')||(LA6_1>='\u000B' && LA6_1<='\f')||(LA6_1>='\u000E' && LA6_1<='\uFFFF')))
					{
						alt6 = 1;
					}


					} finally { DebugExitDecision(6); }
					switch ( alt6 )
					{
					case 1:
						DebugEnterAlt(1);
						// MessageContracts.g:
						{
						DebugLocation(146, 14);
						input.Consume();


						}
						break;

					default:
						goto loop6;
					}
				}

				loop6:
					;

				} finally { DebugExitSubRule(6); }

				DebugLocation(146, 28);
				// MessageContracts.g:146:28: ( '\\r' )?
				int alt7=2;
				try { DebugEnterSubRule(7);
				try { DebugEnterDecision(7, false);
				int LA7_1 = input.LA(1);

				if ((LA7_1=='\r'))
				{
					alt7 = 1;
				}
				} finally { DebugExitDecision(7); }
				switch (alt7)
				{
				case 1:
					DebugEnterAlt(1);
					// MessageContracts.g:146:28: '\\r'
					{
					DebugLocation(146, 28);
					Match('\r'); 

					}
					break;

				}
				} finally { DebugExitSubRule(7); }

				DebugLocation(146, 34);
				Match('\n'); 
				DebugLocation(146, 39);
				_channel=HIDDEN;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MessageContracts.g:147:9: '/*' ( options {greedy=false; } : . )* '*/'
				{
				DebugLocation(147, 9);
				Match("/*"); 

				DebugLocation(147, 14);
				// MessageContracts.g:147:14: ( options {greedy=false; } : . )*
				try { DebugEnterSubRule(8);
				while (true)
				{
					int alt8=2;
					try { DebugEnterDecision(8, false);
					int LA8_1 = input.LA(1);

					if ((LA8_1=='*'))
					{
						int LA8_2 = input.LA(2);

						if ((LA8_2=='/'))
						{
							alt8 = 2;
						}
						else if (((LA8_2>='\u0000' && LA8_2<='.')||(LA8_2>='0' && LA8_2<='\uFFFF')))
						{
							alt8 = 1;
						}


					}
					else if (((LA8_1>='\u0000' && LA8_1<=')')||(LA8_1>='+' && LA8_1<='\uFFFF')))
					{
						alt8 = 1;
					}


					} finally { DebugExitDecision(8); }
					switch ( alt8 )
					{
					case 1:
						DebugEnterAlt(1);
						// MessageContracts.g:147:42: .
						{
						DebugLocation(147, 42);
						MatchAny(); 

						}
						break;

					default:
						goto loop8;
					}
				}

				loop8:
					;

				} finally { DebugExitSubRule(8); }

				DebugLocation(147, 47);
				Match("*/"); 

				DebugLocation(147, 52);
				_channel=HIDDEN;

				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("COMMENT", 26);
			LeaveRule("COMMENT", 26);
			LeaveRule_COMMENT();
		}
	}
	// $ANTLR end "COMMENT"

	partial void EnterRule_WS();
	partial void LeaveRule_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		EnterRule_WS();
		EnterRule("WS", 27);
		TraceIn("WS", 27);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MessageContracts.g:150:5: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
			DebugEnterAlt(1);
			// MessageContracts.g:150:9: ( ' ' | '\\t' | '\\r' | '\\n' )
			{
			DebugLocation(150, 9);
			if ((input.LA(1)>='\t' && input.LA(1)<='\n')||input.LA(1)=='\r'||input.LA(1)==' ')
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}

			DebugLocation(154, 11);
			_channel=HIDDEN;

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 27);
			LeaveRule("WS", 27);
			LeaveRule_WS();
		}
	}
	// $ANTLR end "WS"

	public override void mTokens()
	{
		// MessageContracts.g:1:8: ( T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | EXPLICIT | IF | USING | CONST | INTERFACE | NAMESPACE | EXTERN | ASYNC | ID | Modifier | INT | ARRAY | STRING | COMMENT | WS )
		int alt10=23;
		try { DebugEnterDecision(10, false);
		try
		{
			alt10 = dfa10.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(10); }
		switch (alt10)
		{
		case 1:
			DebugEnterAlt(1);
			// MessageContracts.g:1:10: T__39
			{
			DebugLocation(1, 10);
			mT__39(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// MessageContracts.g:1:16: T__40
			{
			DebugLocation(1, 16);
			mT__40(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// MessageContracts.g:1:22: T__41
			{
			DebugLocation(1, 22);
			mT__41(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// MessageContracts.g:1:28: T__42
			{
			DebugLocation(1, 28);
			mT__42(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// MessageContracts.g:1:34: T__43
			{
			DebugLocation(1, 34);
			mT__43(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// MessageContracts.g:1:40: T__44
			{
			DebugLocation(1, 40);
			mT__44(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// MessageContracts.g:1:46: T__45
			{
			DebugLocation(1, 46);
			mT__45(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// MessageContracts.g:1:52: T__46
			{
			DebugLocation(1, 52);
			mT__46(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// MessageContracts.g:1:58: EXPLICIT
			{
			DebugLocation(1, 58);
			mEXPLICIT(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// MessageContracts.g:1:67: IF
			{
			DebugLocation(1, 67);
			mIF(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// MessageContracts.g:1:70: USING
			{
			DebugLocation(1, 70);
			mUSING(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// MessageContracts.g:1:76: CONST
			{
			DebugLocation(1, 76);
			mCONST(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// MessageContracts.g:1:82: INTERFACE
			{
			DebugLocation(1, 82);
			mINTERFACE(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MessageContracts.g:1:92: NAMESPACE
			{
			DebugLocation(1, 92);
			mNAMESPACE(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MessageContracts.g:1:102: EXTERN
			{
			DebugLocation(1, 102);
			mEXTERN(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MessageContracts.g:1:109: ASYNC
			{
			DebugLocation(1, 109);
			mASYNC(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MessageContracts.g:1:115: ID
			{
			DebugLocation(1, 115);
			mID(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MessageContracts.g:1:118: Modifier
			{
			DebugLocation(1, 118);
			mModifier(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MessageContracts.g:1:127: INT
			{
			DebugLocation(1, 127);
			mINT(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MessageContracts.g:1:131: ARRAY
			{
			DebugLocation(1, 131);
			mARRAY(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MessageContracts.g:1:137: STRING
			{
			DebugLocation(1, 137);
			mSTRING(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MessageContracts.g:1:144: COMMENT
			{
			DebugLocation(1, 144);
			mCOMMENT(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MessageContracts.g:1:152: WS
			{
			DebugLocation(1, 152);
			mWS(); 

			}
			break;

		}

	}


	#region DFA
	DFA10 dfa10;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa10 = new DFA10(this);
	}

	private class DFA10 : DFA
	{
		private const string DFA10_eotS =
			"\x9\xFFFF\x6\xF\x8\xFFFF\x1\xF\x1\x20\x7\xF\x1\xFFFF\xF\xF\x1\x37\x1"+
			"\x38\x1\xF\x1\x3A\x1\xF\x1\x3C\x1\xF\x2\xFFFF\x1\xF\x1\xFFFF\x1\xF\x1"+
			"\xFFFF\x2\xF\x1\x42\x2\xF\x1\xFFFF\x1\x45\x1\x46\x2\xFFFF";
		private const string DFA10_eofS =
			"\x47\xFFFF";
		private const string DFA10_minS =
			"\x1\x9\x8\xFFFF\x1\x78\x1\x66\x1\x73\x1\x6F\x1\x61\x1\x73\x8\xFFFF\x1"+
			"\x70\x1\x30\x1\x74\x1\x69\x1\x6E\x1\x6D\x1\x79\x1\x6C\x1\x65\x1\xFFFF"+
			"\x1\x65\x1\x6E\x1\x73\x1\x65\x1\x6E\x1\x69\x2\x72\x1\x67\x1\x74\x1\x73"+
			"\x2\x63\x1\x6E\x1\x66\x2\x30\x1\x70\x1\x30\x1\x69\x1\x30\x1\x61\x2\xFFFF"+
			"\x1\x61\x1\xFFFF\x1\x74\x1\xFFFF\x2\x63\x1\x30\x2\x65\x1\xFFFF\x2\x30"+
			"\x2\xFFFF";
		private const string DFA10_maxS =
			"\x1\x7D\x8\xFFFF\x1\x78\x1\x6E\x1\x73\x1\x6F\x1\x61\x1\x73\x8\xFFFF\x1"+
			"\x74\x1\x7A\x1\x74\x1\x69\x1\x6E\x1\x6D\x1\x79\x1\x6C\x1\x65\x1\xFFFF"+
			"\x1\x65\x1\x6E\x1\x73\x1\x65\x1\x6E\x1\x69\x2\x72\x1\x67\x1\x74\x1\x73"+
			"\x2\x63\x1\x6E\x1\x66\x2\x7A\x1\x70\x1\x7A\x1\x69\x1\x7A\x1\x61\x2\xFFFF"+
			"\x1\x61\x1\xFFFF\x1\x74\x1\xFFFF\x2\x63\x1\x7A\x2\x65\x1\xFFFF\x2\x7A"+
			"\x2\xFFFF";
		private const string DFA10_acceptS =
			"\x1\xFFFF\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x6\xFFFF\x1"+
			"\x11\x1\x12\x1\x13\x1\x14\x1\x15\x1\x16\x1\x17\x1\x5\x9\xFFFF\x1\xA\x16"+
			"\xFFFF\x1\xB\x1\xC\x1\xFFFF\x1\x10\x1\xFFFF\x1\xF\x5\xFFFF\x1\x9\x2\xFFFF"+
			"\x1\xD\x1\xE";
		private const string DFA10_specialS =
			"\x47\xFFFF}>";
		private static readonly string[] DFA10_transitionS =
			{
				"\x2\x15\x2\xFFFF\x1\x15\x12\xFFFF\x1\x15\x1\x10\x1\x13\x5\xFFFF\x1\x1"+
				"\x1\x2\x2\xFFFF\x1\x3\x1\xFFFF\x1\x4\x1\x14\xA\x11\x1\xFFFF\x1\x5\x1"+
				"\xFFFF\x1\x6\x1\xFFFF\x1\x10\x1\xFFFF\x1A\xF\x1\x12\x3\xFFFF\x1\xF\x1"+
				"\xFFFF\x1\xE\x1\xF\x1\xC\x1\xF\x1\x9\x3\xF\x1\xA\x4\xF\x1\xD\x6\xF\x1"+
				"\xB\x5\xF\x1\x7\x1\xFFFF\x1\x8",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x17",
				"\x1\x18\x7\xFFFF\x1\x19",
				"\x1\x1A",
				"\x1\x1B",
				"\x1\x1C",
				"\x1\x1D",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"\x1\x1E\x3\xFFFF\x1\x1F",
				"\xA\xF\x2\xFFFF\x1\xF\x1\xFFFF\x1\xF\x2\xFFFF\x1B\xF\x1\xFFFF\x1\xF"+
				"\x1\xFFFF\x1\xF\x1\xFFFF\x1A\xF",
				"\x1\x21",
				"\x1\x22",
				"\x1\x23",
				"\x1\x24",
				"\x1\x25",
				"\x1\x26",
				"\x1\x27",
				"",
				"\x1\x28",
				"\x1\x29",
				"\x1\x2A",
				"\x1\x2B",
				"\x1\x2C",
				"\x1\x2D",
				"\x1\x2E",
				"\x1\x2F",
				"\x1\x30",
				"\x1\x31",
				"\x1\x32",
				"\x1\x33",
				"\x1\x34",
				"\x1\x35",
				"\x1\x36",
				"\xA\xF\x2\xFFFF\x1\xF\x1\xFFFF\x1\xF\x2\xFFFF\x1B\xF\x1\xFFFF\x1\xF"+
				"\x1\xFFFF\x1\xF\x1\xFFFF\x1A\xF",
				"\xA\xF\x2\xFFFF\x1\xF\x1\xFFFF\x1\xF\x2\xFFFF\x1B\xF\x1\xFFFF\x1\xF"+
				"\x1\xFFFF\x1\xF\x1\xFFFF\x1A\xF",
				"\x1\x39",
				"\xA\xF\x2\xFFFF\x1\xF\x1\xFFFF\x1\xF\x2\xFFFF\x1B\xF\x1\xFFFF\x1\xF"+
				"\x1\xFFFF\x1\xF\x1\xFFFF\x1A\xF",
				"\x1\x3B",
				"\xA\xF\x2\xFFFF\x1\xF\x1\xFFFF\x1\xF\x2\xFFFF\x1B\xF\x1\xFFFF\x1\xF"+
				"\x1\xFFFF\x1\xF\x1\xFFFF\x1A\xF",
				"\x1\x3D",
				"",
				"",
				"\x1\x3E",
				"",
				"\x1\x3F",
				"",
				"\x1\x40",
				"\x1\x41",
				"\xA\xF\x2\xFFFF\x1\xF\x1\xFFFF\x1\xF\x2\xFFFF\x1B\xF\x1\xFFFF\x1\xF"+
				"\x1\xFFFF\x1\xF\x1\xFFFF\x1A\xF",
				"\x1\x43",
				"\x1\x44",
				"",
				"\xA\xF\x2\xFFFF\x1\xF\x1\xFFFF\x1\xF\x2\xFFFF\x1B\xF\x1\xFFFF\x1\xF"+
				"\x1\xFFFF\x1\xF\x1\xFFFF\x1A\xF",
				"\xA\xF\x2\xFFFF\x1\xF\x1\xFFFF\x1\xF\x2\xFFFF\x1B\xF\x1\xFFFF\x1\xF"+
				"\x1\xFFFF\x1\xF\x1\xFFFF\x1A\xF",
				"",
				""
			};

		private static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
		private static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
		private static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
		private static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
		private static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
		private static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
		private static readonly short[][] DFA10_transition;

		static DFA10()
		{
			int numStates = DFA10_transitionS.Length;
			DFA10_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA10_transition[i] = DFA.UnpackEncodedString(DFA10_transitionS[i]);
			}
		}

		public DFA10( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 10;
			this.eot = DFA10_eot;
			this.eof = DFA10_eof;
			this.min = DFA10_min;
			this.max = DFA10_max;
			this.accept = DFA10_accept;
			this.special = DFA10_special;
			this.transition = DFA10_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | EXPLICIT | IF | USING | CONST | INTERFACE | NAMESPACE | EXTERN | ASYNC | ID | Modifier | INT | ARRAY | STRING | COMMENT | WS );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MessageContracts 
