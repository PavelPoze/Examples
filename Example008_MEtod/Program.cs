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
