using System;

namespace test3
{
    class MainClass
    {
        public static EbnfGrammar Test3 ()
        {
            var G = new EbnfGrammar ();

            EbnfNonterminal N06 = new EbnfNonterminal ("файл");
            EbnfNonterminal N07 = new EbnfNonterminal ("маркер");
            EbnfNonterminal N08 = new EbnfNonterminal ("гм");
            EbnfNonterminal N09 = new EbnfNonterminal ("обм");
            EbnfNonterminal N10 = new EbnfNonterminal ("ябм");
            EbnfNonterminal N11 = new EbnfNonterminal ("тп");
            EbnfNonterminal N12 = new EbnfNonterminal ("табуляция");
            EbnfNonterminal N13 = new EbnfNonterminal ("пробел");
            EbnfNonterminal N14 = new EbnfNonterminal ("новая строка");
            EbnfNonterminal N15 = new EbnfNonterminal ("перевод строки");
            EbnfNonterminal N16 = new EbnfNonterminal ("возврат каретки");
            EbnfNonterminal N17 = new EbnfNonterminal ("комментарий");
            EbnfNonterminal N18 = new EbnfNonterminal ("знак");
            EbnfNonterminal N21 = new EbnfNonterminal ("десятичная цифра");
            EbnfNonterminal N22 = new EbnfNonterminal ("буква");
            EbnfNonterminal N30 = new EbnfNonterminal ("знак препинания");
            EbnfNonterminal N32 = new EbnfNonterminal ("расширение текстореза");
            EbnfNonterminal N33 = new EbnfNonterminal ("двойная кавычка");
            EbnfNonterminal N34 = new EbnfNonterminal ("правило");
            EbnfNonterminal N35 = new EbnfNonterminal ("выражение");
            EbnfNonterminal N36 = new EbnfNonterminal ("перечисление");
            EbnfNonterminal N37 = new EbnfNonterminal ("выбор");
            EbnfNonterminal N38 = new EbnfNonterminal ("имя");
            EbnfNonterminal N39 = new EbnfNonterminal ("часть имени");
            EbnfNonterminal N40 = new EbnfNonterminal ("строка");
            EbnfNonterminal N41 = new EbnfNonterminal ("символ в строке");
            EbnfNonterminal N42 = new EbnfNonterminal ("символ из битов");
            EbnfNonterminal N43 = new EbnfNonterminal ("шестнадцатеричная цифра");
            EbnfNonterminal N44 = new EbnfNonterminal ("любой символ");
            EbnfNonterminal N45 = new EbnfNonterminal ("утаивание");
            EbnfNonterminal N46 = new EbnfNonterminal ("группировка");
            EbnfNonterminal N47 = new EbnfNonterminal ("повторение");
            EbnfNonterminal N49 = new EbnfNonterminal ("не менее");
            EbnfNonterminal N50 = new EbnfNonterminal ("десятичное число");
            EbnfNonterminal N51 = new EbnfNonterminal ("не более");
            EbnfNonterminal N52 = new EbnfNonterminal ("исключение");

            EbnfTerminal T430 = new EbnfTerminal ("а"); EbnfTerminal T410 = new EbnfTerminal ("А");
            EbnfTerminal T431 = new EbnfTerminal ("б"); EbnfTerminal T411 = new EbnfTerminal ("Б");
            EbnfTerminal T432 = new EbnfTerminal ("в"); EbnfTerminal T412 = new EbnfTerminal ("В");
            EbnfTerminal T433 = new EbnfTerminal ("г"); EbnfTerminal T413 = new EbnfTerminal ("Г");
            EbnfTerminal T434 = new EbnfTerminal ("д"); EbnfTerminal T414 = new EbnfTerminal ("Д");
            EbnfTerminal T435 = new EbnfTerminal ("е"); EbnfTerminal T415 = new EbnfTerminal ("Е");
            EbnfTerminal T451 = new EbnfTerminal ("ё"); EbnfTerminal T401 = new EbnfTerminal ("Ё");
            EbnfTerminal T436 = new EbnfTerminal ("ж"); EbnfTerminal T116 = new EbnfTerminal ("Ж");
            EbnfTerminal T437 = new EbnfTerminal ("з"); EbnfTerminal T417 = new EbnfTerminal ("З");
            EbnfTerminal T438 = new EbnfTerminal ("и"); EbnfTerminal T418 = new EbnfTerminal ("И");
            EbnfTerminal T439 = new EbnfTerminal ("й"); EbnfTerminal T419 = new EbnfTerminal ("Й");
            EbnfTerminal T43A = new EbnfTerminal ("к"); EbnfTerminal T41A = new EbnfTerminal ("К");
            EbnfTerminal T43B = new EbnfTerminal ("л"); EbnfTerminal T41B = new EbnfTerminal ("Л");
            EbnfTerminal T43C = new EbnfTerminal ("м"); EbnfTerminal T41C = new EbnfTerminal ("М");
            EbnfTerminal T43D = new EbnfTerminal ("н"); EbnfTerminal T41В = new EbnfTerminal ("Н");
            EbnfTerminal T43E = new EbnfTerminal ("о"); EbnfTerminal T41E = new EbnfTerminal ("О");
            EbnfTerminal T43F = new EbnfTerminal ("п"); EbnfTerminal T41F = new EbnfTerminal ("П");
            EbnfTerminal T440 = new EbnfTerminal ("р"); EbnfTerminal T420 = new EbnfTerminal ("Р");
            EbnfTerminal T441 = new EbnfTerminal ("с"); EbnfTerminal T421 = new EbnfTerminal ("С");
            EbnfTerminal T442 = new EbnfTerminal ("т"); EbnfTerminal T422 = new EbnfTerminal ("Т");
            EbnfTerminal T443 = new EbnfTerminal ("у"); EbnfTerminal T423 = new EbnfTerminal ("У");
            EbnfTerminal T444 = new EbnfTerminal ("ф"); EbnfTerminal T424 = new EbnfTerminal ("Ф");
            EbnfTerminal T445 = new EbnfTerminal ("х"); EbnfTerminal T425 = new EbnfTerminal ("Х");
            EbnfTerminal T446 = new EbnfTerminal ("ц"); EbnfTerminal T426 = new EbnfTerminal ("Ц");
            EbnfTerminal T447 = new EbnfTerminal ("ч"); EbnfTerminal T427 = new EbnfTerminal ("Ч");
            EbnfTerminal T448 = new EbnfTerminal ("ш"); EbnfTerminal T428 = new EbnfTerminal ("Ш");
            EbnfTerminal T449 = new EbnfTerminal ("щ"); EbnfTerminal T429 = new EbnfTerminal ("Щ");
            EbnfTerminal T44A = new EbnfTerminal ("ъ"); EbnfTerminal T42A = new EbnfTerminal ("Ъ");
            EbnfTerminal T44B = new EbnfTerminal ("ы"); EbnfTerminal T42B = new EbnfTerminal ("Ы");
            EbnfTerminal T44C = new EbnfTerminal ("ь"); EbnfTerminal T42C = new EbnfTerminal ("Ь");
            EbnfTerminal T44D = new EbnfTerminal ("э"); EbnfTerminal T42D = new EbnfTerminal ("Э");
            EbnfTerminal T44E = new EbnfTerminal ("ю"); EbnfTerminal T42E = new EbnfTerminal ("Ю");
            EbnfTerminal T44F = new EbnfTerminal ("я"); EbnfTerminal T42А = new EbnfTerminal ("Я");

            EbnfTerminal T030 = new EbnfTerminal ("0"); EbnfTerminal T031 = new EbnfTerminal ("1");
            EbnfTerminal T032 = new EbnfTerminal ("2"); EbnfTerminal T033 = new EbnfTerminal ("3");
            EbnfTerminal T034 = new EbnfTerminal ("4"); EbnfTerminal T035 = new EbnfTerminal ("5");
            EbnfTerminal T036 = new EbnfTerminal ("6"); EbnfTerminal T037 = new EbnfTerminal ("7");
            EbnfTerminal T038 = new EbnfTerminal ("8"); EbnfTerminal T039 = new EbnfTerminal ("9");

            EbnfTerminal T03D = new EbnfTerminal ("=");
            EbnfTerminal T03A = new EbnfTerminal (":");
            EbnfTerminal T028 = new EbnfTerminal ("("); EbnfTerminal T029 = new EbnfTerminal (")");
            EbnfTerminal T05B = new EbnfTerminal ("["); EbnfTerminal T05D = new EbnfTerminal ("]");
            EbnfTerminal T07B = new EbnfTerminal ("{"); EbnfTerminal T07D = new EbnfTerminal ("}");
            EbnfTerminal T03B = new EbnfTerminal (";");
            EbnfTerminal T03F = new EbnfTerminal ("?");
            EbnfTerminal T02E = new EbnfTerminal ("."); EbnfTerminal T02C = new EbnfTerminal (",");
            EbnfTerminal T02A = new EbnfTerminal ("*"); EbnfTerminal T02D = new EbnfTerminal ("-");

            var R22 = new EbnfRule (N22, new EbnfExpression (new IEbnfExpressionPart [] {
                T430, T410, T431, T411, T432, T412, T433, T413, T434, T414, T435, T415, T451, T401,
                T436, T116, T437, T417, T438, T418, T439, T419, T43A, T41A, T43B, T41B, T43C, T41C,
                T43D, T41В, T43E, T41E, T43F, T41F, T440, T420, T441, T421, T442, T422, T443, T423,
                T444, T424, T445, T425, T446, T426, T447, T427, T448, T428, T449, T429, T44A, T42A,
                T44B, T42B, T44C, T42C, T44D, T42D, T44E, T42E, T44F, T42А
            })); G.Add (R22);

            return G;
        }
        public static void Main (string [] args)
        {
            var EG = Test3 ();
            var c = new FromEbnfToBnf_ByCopying (EG);
            var text = new SymbolReader ("cad");
            var pc = new RecursiveDescentParser (text);
            var res = pc.RecusiveDescent (c.Bnf ["S"]);
            Console.WriteLine (res);
        }
    }
}
