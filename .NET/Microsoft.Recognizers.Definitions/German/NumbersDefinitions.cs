﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//     Generation parameters:
//     - DataFilename: Patterns\German\German-Numbers.yaml
//     - Language: German
//     - ClassName: NumbersDefinitions
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions.German
{
	using System;
	using System.Collections.Generic;

	public static class NumbersDefinitions
	{
		public const string LangMarker = "Ger";
		public const string RoundNumberIntegerRegex = @"(hundert|tausend|million|millionen|milliarde|milliarden|billion|billionen)";
		public const string ZeroToNineIntegerRegex = @"(drei|sieben|acht|vier|fuenf|fünf|null|neun|eins|zwei|sechs)";
		public const string AnIntRegex = @"(eine|ein)(?=\s)";
		public const string TenToNineteenIntegerRegex = @"(siebzehn|dreizehn|vierzehn|achtzehn|neunzehn|fuenfzehn|sechzehn|elf|zwoelf|zwölf|zehn)";
		public const string TensNumberIntegerRegex = @"(siebzig|zwanzig|dreißig|achtzig|neunzig|vierzig|fuenfzig|fünfzig|sechzig)";
		public static readonly string SeparaIntRegex = $@"((({TenToNineteenIntegerRegex}|({TensNumberIntegerRegex}(\s+(and\s+)?|\s*-\s*){ZeroToNineIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex})(\s+{RoundNumberIntegerRegex})*))|(({AnIntRegex}(\s+{RoundNumberIntegerRegex})+))";
		public static readonly string AllIntRegex = $@"(((({TenToNineteenIntegerRegex}|({TensNumberIntegerRegex}(\s+(and\s+)?|\s*-\s*){ZeroToNineIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex}|{AnIntRegex})(\s+{RoundNumberIntegerRegex})+)\s+(and\s+)?)*{SeparaIntRegex})";
		public const string PlaceHolderPureNumber = @"\b";
		public const string PlaceHolderDefault = @"\D|\b";
		public static readonly Func<string, string> NumbersWithPlaceHolder = (placeholder) => $@"(((?<!\d+\s*)-\s*)|(?<=\b))\d+(?!(\.\d+[a-zA-Z]))(?={placeholder})";
		public const string NumbersWithSuffix = @"(((?<!\d+\s*)-\s*)|(?<=\b))\d+\s*(K|k|M|T|G)(?=\b)";
		public static readonly string RoundNumberIntegerRegexWithLocks = $@"(?<=\b)\d+\s+{RoundNumberIntegerRegex}(?=\b)";
		public const string NumbersWithDozenSuffix = @"(((?<!\d+\s*)-\s*)|(?<=\b))\d+\s+dutzend(e)?(?=\b)";
		public static readonly string AllIntRegexWithLocks = $@"((?<=\b){AllIntRegex}(?=\b))";
		public static readonly string AllIntRegexWithDozenSuffixLocks = $@"(?<=\b)(((ein\s+)?halbes\s+dutzend)|({AllIntRegex}\s+dozen(s)?))(?=\b)";
		public const string RoundNumberOrdinalRegex = @"(hundertstel|tausendstel|millionstel|milliardstel|trillionstel)";
		public const string BasicOrdinalRegex = @"(erster|erste|erstes|zweiter|zweite|zweites|dritter|dritte|drittes|drittel|vierter|vierte|viertes|fünfter|fünfte|fünftes|fuenfter|fuenfte|fuenftes|sechster|sechste|sechstes|siebter|siebte|siebter|achter|achte|achtes|neunter|neunte|neuntes|tenth|eleventh|twelfth|thirteenth|fourteenth|fifteenth|sixteenth|seventeenth|eighteenth|nineteenth|twentieth|thirtieth|fortieth|fiftieth|sixtieth|seventieth|eightieth|ninetieth)";
		public static readonly string SuffixBasicOrdinalRegex = $@"((((({TensNumberIntegerRegex}(\s+(and\s+)?|\s*-\s*){ZeroToNineIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex}|{AnIntRegex})(\s+{RoundNumberIntegerRegex})+)\s+(and\s+)?)*({TensNumberIntegerRegex}(\s+|\s*-\s*))?{BasicOrdinalRegex})";
		public static readonly string SuffixRoundNumberOrdinalRegex = $@"(({AllIntRegex}\s+){RoundNumberOrdinalRegex})";
		public static readonly string AllOrdinalRegex = $@"({SuffixBasicOrdinalRegex}|{SuffixRoundNumberOrdinalRegex})";
		public const string OrdinalSuffixRegex = @"(?<=\b)((\d*(1st|2nd|3rd|4th|5th|6th|7th|8th|9th|0th))|(11th|12th))(?=\b)";
		public const string OrdinalNumericRegex = @"(?<=\b)(\d{1,3}(\s*,\s*\d{3})*\s*th)(?=\b)";
		public static readonly string OrdinalRoundNumberRegex = $@"(?<!(a|an)\s+){RoundNumberOrdinalRegex}";
		public static readonly string OrdinalGermanRegex = $@"(?<=\b){AllOrdinalRegex}(?=\b)";
		public const string FractionNotationWithSpacesRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s+\d+[/]\d+(?=(\b[^/]|$))";
		public const string FractionNotationRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+[/]\d+(?=(\b[^/]|$))";
		public static readonly string FractionNounRegex = $@"(?<=\b)({AllIntRegex}\s+(and\s+)?)?({AllIntRegex})(\s+|\s*-\s*)((({AllOrdinalRegex})|({RoundNumberOrdinalRegex}))s|halves|quarters)(?=\b)";
		public static readonly string FractionNounWithArticleRegex = $@"(?<=\b)({AllIntRegex}\s+(and\s+)?)?(a|an|one)(\s+|\s*-\s*)(({AllOrdinalRegex})|({RoundNumberOrdinalRegex})|half|quarter)(?=\b)";
		public static readonly string FractionPrepositionRegex = $@"(?<=\b)(({AllIntRegex})|((?<!\.)\d+))\s+over\s+(({AllIntRegex})|(\d+)(?!\.))(?=\b)";
		public static readonly string AllPointRegex = $@"((\s+{ZeroToNineIntegerRegex})+|(\s+{SeparaIntRegex}))";
		public static readonly string AllFloatRegex = $@"{AllIntRegex}(\s+point){AllPointRegex}";
		public const string DoubleWithMultiplierRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\.)))\d+\.\d+\s*(K|k|M|G|T|B|b)(?=\b)";
		public const string DoubleExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\.)))(\d+(\.\d+)?)e([+-]*[1-9]\d*)(?=\b)";
		public const string DoubleCaretExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\.)))(\d+(\.\d+)?)\^([+-]*[1-9]\d*)(?=\b)";
		public static readonly Func<string, string> DoubleDecimalPointRegex = (placeholder) => $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\.)))\d+\.\d+(?!(\.\d+))(?={placeholder})";
		public static readonly Func<string, string> DoubleWithoutIntegralRegex = (placeholder) => $@"(?<=\s|^)(?<!(\d+))\.\d+(?!(\.\d+))(?={placeholder})";
		public static readonly string DoubleWithRoundNumber = $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\.)))\d+\.\d+\s+{RoundNumberIntegerRegex}(?=\b)";
		public static readonly string DoubleAllFloatRegex = $@"((?<=\b){AllFloatRegex}(?=\b))";
		public const string CurrencyRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s*(B|b|m|t|g)(?=\b)";
		public static readonly string NumberWithSuffixPercentage = $@"({BaseNumbers.NumberReplaceToken})(\s*)(%|per cents|per cent|cents|cent|percentage|percents|percent)";
		public static readonly string NumberWithPrefixPercentage = $@"(per cent of|percent of|percents of)(\s*)({BaseNumbers.NumberReplaceToken})";
		public const char DecimalSeparatorChar = ',';
		public const string FractionMarkerToken = "over";
		public const char NonDecimalSeparatorChar = '.';
		public const string HalfADozenText = "six";
		public const string WordSeparatorToken = "und";
		public static readonly string[] WrittenDecimalSeparatorTexts = { "Komma" };
		public static readonly string[] WrittenGroupSeparatorTexts = { "Punkt" };
		public static readonly string[] WrittenIntegerSeparatorTexts = { "und" };
		public static readonly string[] WrittenFractionSeparatorTexts = { "und" };
		public const string HalfADozenRegex = @"ein\s+halbes\s+dutzend";
		public const string DigitalNumberRegex = @"((?<=\b)(hundert|tausend|million|millionen|milliarde|trillion|dozen(s)?)(?=\b))|((?<=(\d|\b))(k|t|m|g|b)(?=\b))";
		public static readonly Dictionary<string, long> CardinalNumberMap = new Dictionary<string, long>
		{
			{ "ein", 1 },
			{ "null", 0 },
			{ "eine", 1 },
			{ "eins", 1 },
			{ "zwei", 2 },
			{ "drei", 3 },
			{ "vier", 4 },
			{ "fünf", 5 },
			{ "fuenf", 5 },
			{ "sechs", 6 },
			{ "sieben", 7 },
			{ "acht", 8 },
			{ "neun", 9 },
			{ "zehn", 10 },
			{ "elf", 11 },
			{ "zwölf", 12 },
			{ "zwoelf", 12 },
			{ "dutzend", 12 },
			{ "dreizehn", 13 },
			{ "vierzehn", 14 },
			{ "fünfzehn", 15 },
			{ "fuenfzehn", 15 },
			{ "sechzehn", 16 },
			{ "siebzehn", 17 },
			{ "achtzehn", 18 },
			{ "neunzehn", 19 },
			{ "zwanzig", 20 },
			{ "dreißig", 30 },
			{ "vierzig", 40 },
			{ "fünfzig", 50 },
			{ "fuenfzig", 50 },
			{ "sechzig", 60 },
			{ "siebzig", 70 },
			{ "achtzig", 80 },
			{ "neunzig", 90 },
			{ "hundert", 100 },
			{ "tausend", 1000 },
			{ "million", 1000000 },
			{ "millionen", 1000000 },
			{ "milliarde", 1000000000 },
			{ "milliarden", 1000000000 },
			{ "billion", 1000000000000 },
			{ "billionen", 1000000000000 }
		};
		public static readonly Dictionary<string, long> OrdinalNumberMap = new Dictionary<string, long>
		{
			{ "/erst?(?:er|es|en|e)/", 1 },
			{ "erster", 1 },
			{ "erste", 1 },
			{ "erstes", 1 },
			{ "ersten", 1 },
			{ "zweiter", 2 },
			{ "zweite", 2 },
			{ "zweites", 2 },
			{ "zweiten", 2 },
			{ "halb", 2 },
			{ "hälfte", 2 },
			{ "haelfte", 2 },
			{ "dritter", 3 },
			{ "dritte", 3 },
			{ "drittes", 3 },
			{ "dritten", 3 },
			{ "drittel", 3 },
			{ "vierter", 4 },
			{ "vierte", 4 },
			{ "viertes", 4 },
			{ "vierten", 4 },
			{ "viertel", 4 },
			{ "fünfter", 5 },
			{ "fünfte", 5 },
			{ "fünftes", 5 },
			{ "fünften", 5 },
			{ "fuenfter", 5 },
			{ "fuenfte", 5 },
			{ "fuenftes", 5 },
			{ "fuenften", 5 },
			{ "fünftel", 5 },
			{ "fuenftel", 5 },
			{ "sechster", 6 },
			{ "sechste", 6 },
			{ "sechstes", 6 },
			{ "sechsten", 6 },
			{ "sechstel", 6 },
			{ "siebter", 7 },
			{ "siebte", 7 },
			{ "siebtes", 7 },
			{ "siebten", 7 },
			{ "siebtel", 7 },
			{ "achter", 8 },
			{ "achte", 8 },
			{ "achtes", 8 },
			{ "achten", 8 },
			{ "achtel", 8 },
			{ "neunter", 9 },
			{ "neunte", 9 },
			{ "neuntes", 9 },
			{ "neunten", 9 },
			{ "neuntel", 9 },
			{ "zehnter", 10 },
			{ "zehnte", 10 },
			{ "zehntes", 10 },
			{ "zehnten", 10 },
			{ "zehntel", 10 },
			{ "elfter", 11 },
			{ "elfte", 11 },
			{ "elftes", 11 },
			{ "elften", 11 },
			{ "elftel", 11 },
			{ "zwölfter", 12 },
			{ "zwölfte", 12 },
			{ "zwölftes", 12 },
			{ "zwölften", 12 },
			{ "zwoelfter", 12 },
			{ "zwoelfte", 12 },
			{ "zwoelftes", 12 },
			{ "zwoelften", 12 },
			{ "zwölftel", 12 },
			{ "zwoelftel", 12 },
			{ "dreizehnter", 13 },
			{ "dreizehnte", 13 },
			{ "dreizehntes", 13 },
			{ "dreizehnten", 13 },
			{ "dreizehntel", 13 },
			{ "vierzehnter", 14 },
			{ "vierzehnte", 14 },
			{ "vierzehntes", 14 },
			{ "vierzehnten", 14 },
			{ "vierzehntel", 14 },
			{ "fünfzehnter", 15 },
			{ "fünfzehnte", 15 },
			{ "fünfzehntes", 15 },
			{ "fünfzehnten", 15 },
			{ "fünfzehntel", 15 },
			{ "fuenfzehnter", 15 },
			{ "fuenfzehnte", 15 },
			{ "fuenfzehntes", 15 },
			{ "fuenfzehnten", 15 },
			{ "fuenfzehntel", 15 },
			{ "sechtehnter", 16 },
			{ "sechtehnte", 16 },
			{ "sechtehntes", 16 },
			{ "sechtehnten", 16 },
			{ "sechzehntel", 16 },
			{ "siebzehnter", 17 },
			{ "siebzehnte", 17 },
			{ "siebzehntes", 17 },
			{ "siebzehnten", 17 },
			{ "siebzehntel", 17 },
			{ "achtzehnter", 18 },
			{ "achtzehnte", 18 },
			{ "achtzehntes", 18 },
			{ "achtzehnten", 18 },
			{ "achtzehntel", 18 },
			{ "neunzehnter", 19 },
			{ "neunzehnte", 19 },
			{ "neunzehntes", 19 },
			{ "neunzehnten", 19 },
			{ "neunzehntel", 19 },
			{ "zwanzigster", 20 },
			{ "zwanzigste", 20 },
			{ "zwanzigstes", 20 },
			{ "zwanzigsten", 20 },
			{ "zwangtigstel", 20 },
			{ "dreißigster", 30 },
			{ "dreißigste", 30 },
			{ "dreißigstes", 30 },
			{ "dreißigsten", 30 },
			{ "dreißigstel", 30 },
			{ "vierzigster", 40 },
			{ "vierzigste", 40 },
			{ "vierzigstes", 40 },
			{ "vierzigsten", 40 },
			{ "vierzigstel", 40 },
			{ "fünfzigster", 50 },
			{ "fünfzigste", 50 },
			{ "fünfzigsten", 50 },
			{ "fünfzigstes", 50 },
			{ "fünfzigstel", 50 },
			{ "fuenfzigster", 50 },
			{ "fuenfzigste", 50 },
			{ "fuenfzigstes", 50 },
			{ "fuenfzigsten", 50 },
			{ "fuenfzigstel", 50 },
			{ "sechzigster", 60 },
			{ "sechzigste", 60 },
			{ "sechzigstes", 60 },
			{ "sechzigsten", 60 },
			{ "sechzigstel", 60 },
			{ "siebzigster", 70 },
			{ "siebzigste", 70 },
			{ "siebzigstes", 70 },
			{ "siebzigsten", 70 },
			{ "siebzigstel", 70 },
			{ "achtzigster", 80 },
			{ "achtzigste", 80 },
			{ "achtzigstes", 80 },
			{ "achtzigsten", 80 },
			{ "achtzigstel", 80 },
			{ "neunzigster", 90 },
			{ "neunzigste", 90 },
			{ "neunzigstes", 90 },
			{ "neunzigsten", 90 },
			{ "neunzigstel", 90 },
			{ "hundertster", 100 },
			{ "hundertste", 100 },
			{ "hundertstes", 100 },
			{ "hundertsten", 100 },
			{ "hundertstel", 100 },
			{ "tausendser", 1000 },
			{ "tausendse", 1000 },
			{ "tausendses", 1000 },
			{ "tausendsen", 1000 },
			{ "tausendstel", 1000 },
			{ "millionster", 1000000 },
			{ "millionste", 1000000 },
			{ "millionstes", 1000000 },
			{ "millionsten", 1000000 },
			{ "millionstel", 1000000 },
			{ "milliardster", 1000000000 },
			{ "milliardste", 1000000000 },
			{ "milliardstes", 1000000000 },
			{ "milliardsten", 1000000000 },
			{ "milliardstel", 1000000000 },
			{ "billionster", 1000000000000 },
			{ "billionste", 1000000000000 },
			{ "billionstes", 1000000000000 },
			{ "billionsten", 1000000000000 },
			{ "billionstel", 1000000000000 }
		};
		public static readonly Dictionary<string, long> RoundNumberMap = new Dictionary<string, long>
		{
			{ "hundert", 100 },
			{ "tausend", 1000 },
			{ "million", 1000000 },
			{ "millionen", 1000000 },
			{ "milliarde", 1000000000 },
			{ "milliarden", 1000000000 },
			{ "billion", 1000000000000 },
			{ "billionen", 1000000000000 },
			{ "hundertstel", 100 },
			{ "thousandth", 1000 },
			{ "millionth", 1000000 },
			{ "billionth", 1000000000 },
			{ "trillionth", 1000000000000 },
			{ "hundredths", 100 },
			{ "thousandths", 1000 },
			{ "millionths", 1000000 },
			{ "billionths", 1000000000 },
			{ "trillionths", 1000000000000 },
			{ "dutzend", 12 },
			{ "dutzende", 12 },
			{ "k", 1000 },
			{ "m", 1000000 },
			{ "g", 1000000000 },
			{ "b", 1000000000 },
			{ "t", 1000000000000 }
		};
	}
}