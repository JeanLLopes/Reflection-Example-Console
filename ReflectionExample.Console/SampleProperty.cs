﻿using System;

namespace ReflectionExample
{
    public class SampleProperty
    {
        public string NameExample { get; set; }
        public int AgeExample { get; set; }

        public void MyMethodExample()
        {
            Console.WriteLine($"Result of method {nameof(SampleProperty)}");
        }
    }
}
