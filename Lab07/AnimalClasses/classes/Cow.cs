using AnimalClasses.abstract_classes;
using AnimalClasses.enums;
using AnimalClasses;
using System;

namespace AnimalClasses.classes
{
    [Comment("Class for cow")]
    public class Cow : Animal
    {
        public override eFavoriteFood GetFavoriteFood()
        {
            return eFavoriteFood.Plants;
        }

        public override void SayHello()
        {
            Console.WriteLine("MUUU");
        }
    }
}
