using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBidersNew
{
        internal class Program
        {
            static void Main(string[] args)
            {

            }
        }
        interface IPart
        {
            string Name { get; set; }
            string Material { get; set; }
            bool Built { get; set; }
        }
        interface IWorker
        {
            string Name { set; get; }
        }
        class Basement : IPart
        {
            public string Name { get; set; }
            public string Material { get; set; }
            public bool Built { get; set; }
        }
        class Walls : IPart
        {
            public string Name { get; set; }
            public string Material { get; set; }
            public bool Built { get; set; }
        }
        class Door : IPart
        {
            public string Name { get; set; }
            public string Material { get; set; }
            public bool Built { get; set; }
        }
        class Window : IPart
        {
            public string Name { get; set; }
            public string Material { get; set; }
            public bool Built { get; set; }
        }
        class Roof : IPart
        {
            public string Name { get; set; }
            public string Material { get; set; }
            public bool Built { get; set; }
        }

        class Worker : IWorker
        {
            public string Name { get; set; }
        }
        class TeamLeader : IWorker
        {
            public string Name { get; set; }
        }
        class Team
        {

        }
    }

