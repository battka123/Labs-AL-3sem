using System;
using AnimalClasses.abstract_classes;
using AnimalClasses.enums;

namespace AnimalClasses.classes
{
    [Comment("Class for pig")]
    class Pig : Animal
    {
        public override eFavoriteFood GetFavoriteFood()
        {
            return eFavoriteFood.Everything;
        }

        public override void SayHello()
        {
            Console.WriteLine("OOINK");
        }
    }
}
