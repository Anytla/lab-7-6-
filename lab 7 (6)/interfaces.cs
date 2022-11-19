using System;
//створюємо інтерфейси
interface ICitizen
{
    string? Name { get; set; }
    int? Age { get; set; }
    string? Id { get; set; }
    string? Birthdate { get; set; }
}

interface IPet
{
    string? Name { get; set; }
    string? Birthdate { get; set; }
}

interface IRobot
{
    string? Model { get; set; }
    string? Id { get; set; }
    string? Birthdate { get; set; }
}
