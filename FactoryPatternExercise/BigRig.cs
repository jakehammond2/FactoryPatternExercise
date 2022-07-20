﻿using System;
namespace FactoryPatternExercise
{
    public class BigRig : IVehicle
    {
        public BigRig()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Building a new BigRig");
        }
    }
}

