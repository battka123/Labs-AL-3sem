using System;
using AnimalClasses.abstract_classes;
using AnimalClasses.enums;

namespace AnimalClasses.classes
{
    [Comment("Class for lion")]
    class Lion : Animal
    {
        public override eFavoriteFood GetFavoriteFood()
        {
            return eFavoriteFood.Meat;
        }

        public override void SayHello()
        {
            Console.WriteLine("RAAAR");
        }
    }
}
