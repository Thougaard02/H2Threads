using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DiningPhilsophers
{
    public class Philosopher
    {
        private int _philosofNumber;

        static bool[] _forks = new bool[5];
        public Fork[] Forks;
        public int LeftFork { get; set; }
        public int RightFork { get; set; }
        Random Random = new Random();
        public Philosopher(int philosofNumber)
        {
            //Forks = new Fork[5];
            this._philosofNumber = philosofNumber;
            LeftFork = this._philosofNumber;
            RightFork = (this._philosofNumber + 1) % 5;
        }
        public void TakeFork()
        {
            while (true)
            {
                lock (_forks)
                //lock (Forks)
                {
                    Get(LeftFork, RightFork);
                }
            }
        }
        public void Get(int leftFork, int rightFork)
        {
            lock (this)
            {
                if (_forks[RightFork] == false || _forks[LeftFork] == false)
                //if (Forks[RightFork].IsTaken || Forks[LeftFork].IsTaken)
                {
                    _forks[leftFork] = true;
                    _forks[rightFork] = true;

                    //Forks[leftFork].IsTaken = true;
                    //Forks[rightFork].IsTaken = true;
                    Console.WriteLine($"Philosof {_philosofNumber} is eating");
                    Thread.Sleep(Random.Next(1000, 5000));
                    Monitor.PulseAll(_forks);
                    //Monitor.PulseAll(Forks);
                    Put(LeftFork, RightFork);
                }
            }
        }
        public void Put(int leftFork, int rightFork)
        {
            lock (this)
            {
                _forks[leftFork] = false;
                _forks[rightFork] = false;

                //Forks[leftFork].IsTaken = true;
                //Forks[rightFork].IsTaken = true;
                Console.WriteLine($"...Philosof {this._philosofNumber} has finshed eating and laying down forks");
                Waiting(leftFork, rightFork);
                Monitor.PulseAll(this);
            }
        }
        public void Waiting(int leftFork, int rightFork)
        {
            lock (this)
            {
                if (_forks[rightFork] == false || _forks[leftFork] == false)
                //if (Forks[rightFork].IsTaken|| Forks[leftFork].IsTaken)
                {
                    Console.WriteLine($"......Philosof {this._philosofNumber} is waiting on a fork");
                    Thread.Sleep(Random.Next(1000, 5000));
                }
            }
        }
    }
}
