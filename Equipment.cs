using System;


public class Equipment
{
    public string Name { get; set; }
    public string Condition { get; set; }
}

var equipmentItems = new List<Equipment>
{
    new Equipment {Name = "BasketBall", Condition = "Good"}
    new Equipment {Name = "Tennis Racket" , Condition = "Damaged"}
    new Equipment {Name = "Vollyball" , Condition = "Good"}
}



