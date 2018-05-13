﻿// ******************************************************************************************************************
//  Linq Library - a repo of useful LINQ references
//  Copyright(C) 2018  James LoForti
//  Contact Info: jamesloforti@gmail.com
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.If not, see<https://www.gnu.org/licenses/>.
//									     ____.           .____             _____  _______   
//									    |    |           |    |    ____   /  |  | \   _  \  
//									    |    |   ______  |    |   /  _ \ /   |  |_/  /_\  \ 
//									/\__|    |  /_____/  |    |__(  <_> )    ^   /\  \_/   \
//									\________|           |_______ \____/\____   |  \_____  /
//									                             \/          |__|        \/ 
//
// ******************************************************************************************************************
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
    public class Queries
    {
        public void Run()
        {
            StringGenerator();
            IntegerGenerator();
        }

        public void StringGenerator()
        {
            Random random = new Random();
            string charOptions = "AGCT"; // DNA bases

            Console.Write("StringGenerator: ");
            Console.WriteLine(new string(Enumerable.Repeat(charOptions, 20).Select(s => s[random.Next(s.Length)]).ToArray()));
        }

        public void IntegerGenerator()
        {
            Random random = new Random();
            string intOptions = "0123456789";

            Console.Write("IntegerGenerator: ");
            Console.WriteLine(new string(Enumerable.Repeat(intOptions, 20).Select(s => s[random.Next(s.Length)]).ToArray()));
        }


    } // end class Queries
} // end namespace LinqLibrary
