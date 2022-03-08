using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DiningPhilsophers
{
    public class Philosopher
    {
        private int _philosofNumber;
        private static Fork[] Forks;
        private int LeftFork { get; set; }
        private int RightFork { get; set; }
        private Random Random = new Random();
        public Philosopher(int philosofNumber, Fork[] forks)
        {
            Forks = forks;
            this._philosofNumber = philosofNumber;
            LeftFork = this._philosofNumber;
            RightFork = (this._philosofNumber + 1) % 5;
        }
        public void PhilsofBeginEating()
        {
            while (true)
            {
                lock (Forks)
                {
                    Get(LeftFork, RightFork);
                    //Below methods can be implemented here. Ask Mikkel what is best practices
                    //Put(LeftFork, RightFork);
                    //Waiting(LeftFork, RightFork);
                }
            }
        }
        public void Get(int leftFork, int rightFork)
        {
            lock (this)
            {
                if (Forks[RightFork].IsTaken == false || Forks[LeftFork].IsTaken == false)
                {
                    Forks[leftFork].IsTaken = true;
                    Forks[rightFork].IsTaken = true;
                    Console.WriteLine($"Philosof {_philosofNumber} is eating");
                    Thread.Sleep(Random.Next(1000, 5000));
                    Monitor.PulseAll(Forks);
                    Put(LeftFork, RightFork);
                }
            }
        }
        public void Put(int leftFork, int rightFork)
        {
            lock (this)
            {
                Forks[leftFork].IsTaken = false;
                Forks[rightFork].IsTaken = false;
                Console.WriteLine($"...Philosof {this._philosofNumber} has finshed eating and laying down forks");
                Waiting(leftFork, rightFork);
                Monitor.PulseAll(this);
            }
        }
        public void Waiting(int leftFork, int rightFork)
        {
            lock (this)
            {
                if (Forks[rightFork].IsTaken == false || Forks[leftFork].IsTaken == false)
                {
                    Console.WriteLine($"......Philosof {this._philosofNumber} is waiting on a fork");
                    Thread.Sleep(Random.Next(1000, 5000));
                }
            }
        }
    }
}
