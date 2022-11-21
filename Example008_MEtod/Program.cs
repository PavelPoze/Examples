/*
void Metod1()  //ключевое слово void в скобках пишется аргумент
{
Console.WriteLine("Автор …");
}
 Method1();  //вызов метода (идентификатора метода)

*/
/*
//2
 //Следующая группа методов это пусть так и называется Metod2.
void Metod2(string msg)// — где void ключевое слово, дальше идентификатор, в скобках указаны какие-то аргументы.
{
    Console.WriteLine(msg);// — оператор, в скобках указан принятый аргумент.
}
Metod2(msg: "Текст сообщения"); // — где Metod2 является идентификатором, а в скобках указан текст, выводимый в консоли.


void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {

    Console.WriteLine(msg); //- где переменная count отображает на экране определённое количество сообщений msg.
    i++; // - а надо i++;
    }
}
Metod21("Текст", 4);//- метод вызывает Текст, после запятой указано количество вызовов, в нашем случае 4.
*/


// 3
/*
Третья группа методов
Эти методы, которые что-то возвращают, но ничего не принимают. Если метод что-то
возвращает, мы в обязательном порядке должны указать тип данных, значение которого
ожидаем. Для нас это будет Metod3.*/

/*
int Metod3()    //- не принимает никакие аргументы
{
    return DateTime.Now.Year;    // - обязательное использование оператора return,
}
int year = Metod3();    // - вызываем метод, в левой части используем идентификатор
                         // переменной (year) и через оператор присваивания (=) кладём нужное значение
Console.WriteLine(year);
*/

// 4
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "  asrt");
Console.WriteLine(res);
*/

//Итак, синтаксис цикла for примерно следующий.
/*
string Metod4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++) // - вначале ключевое слово, затем инициализация счётчика, после проверка условия и инкремент (увеличение счётчика).
    {
        result = result + text;
    }
    return result;
}
string res = Metod4(10, "  asdf");
Console.WriteLine(res);
*/
/*
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}

*/


//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?
//Дальше. У нас есть сам текст. Можете в чат написать или в комментариях написать, о том
//узнали ли вы произведения, откуда взят этот текст? И дальше мы уже начинаем писать код.
/*
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
//В нашем случае требуется небольшое пояснение, если будет какая-то строка, то для этой
//строки есть некоторое количество вспомогательного функционала.
// string s = “qwerty”
//             012345
//s[3] // r
/*
string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replase(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(text, 'к', 'К');
Console.WriteLine(newText);
*/
/*


Упорядочить массивы
Было: 6 8 3 2 1 4 5 7
Стало: 1 8 3 2 6 4 5 7
Напишем код*/
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i =0; i < array.Length - 1; i++)
    {
        int  minPozition = i;
        for (int j = i +1 ; j < array.Length; j++)
        {
            if (array[j] < array[minPozition]) minPozition = j;
        }
        ///
        //
        int temporary = array[i];
        array[i] = array[minPozition];
        array[minPozition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
