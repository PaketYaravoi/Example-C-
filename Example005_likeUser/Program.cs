﻿Console.WriteLine("Пожалуйста, введите имя пользователя:");
string username = Console.ReadLine();

if(username == "Roman")
{
    Console.WriteLine("Приветсвую тебя хозяин");
}
else
{
    Console.Write(username);
    Console.WriteLine(",ну привет, я тебя не знаю");
}