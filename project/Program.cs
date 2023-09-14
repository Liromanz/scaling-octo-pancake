/*Console.WriteLine("сколько ложек сахара вы хотите?");
string txt = Console.ReadLine();
int num = Convert.ToInt32(txt);
for (int kolvoLojek = 1; kolvoLojek != num + 1; kolvoLojek++)
{
    Console.WriteLine("Добавили " + kolvoLojek + " ложек в чай");
}
*/

/*bool isListening;

do
{
    Console.WriteLine("Говорю");
    Console.WriteLine("Меня кто-то слушает?");
    isListening = Convert.ToBoolean(Console.ReadLine());
} while (isListening == true);*/
string txt;
do
{
    Console.WriteLine("Выберите цвет");
    Console.WriteLine("1. Красный");
    Console.WriteLine("2. Синий");
    Console.WriteLine("3. Зеленый");
    Console.WriteLine("4. Коричневый");
    Console.WriteLine("5. никакой");
    txt = Console.ReadLine();

    if (txt == "1")
    {
        Console.WriteLine("dddddddddddddddddddd");
    }
    else if (txt == "2")
    {
        Console.WriteLine("111111111111111");
    }
} while (txt != "5");



