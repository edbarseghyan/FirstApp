#region "Settings"
Console.Title = "Познакомимся?";
Console.ForegroundColor = ConsoleColor.Green;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
#endregion

#region "Name"
Anun:
Console.WriteLine("Как тебя зовут?");
var characterName = Console.ReadLine();

while (characterName.Length == 0 | (!characterName.All(char.IsLetter)))

{
    Console.WriteLine("Имя может содержать только буквы!");
    goto Anun;
}
#endregion

#region "Age"
Tarique:
Console.WriteLine("Сколько тебе лет?");
var characterAge = (Console.ReadLine());
int age;

while (!int.TryParse(characterAge, out age))

{
    Console.WriteLine("Ты не ввел возраст! Дай мне цифры!");
    goto Tarique;
}
#endregion

#region "If"
if (age < 42 && age > 0 && characterName.Length > 0)
{
    for (int i = 0; i < 1; i++)
    {
        Console.WriteLine($"Я понял! Тебя зовут {characterName} и тебе {characterAge} лет! Добро пожаловать!");

    }
}
else if (age <= 0)
{
    Console.WriteLine($"Я понял! Тебя зовут {characterName}, но тебе не может быть {characterAge} лет! Иди отсюда!");
}

else
{
    Console.WriteLine($"Тебе {characterAge}, {characterName}, и тебе сюда нельзя!");
}
#endregion
Console.ReadKey();
Console.Clear();