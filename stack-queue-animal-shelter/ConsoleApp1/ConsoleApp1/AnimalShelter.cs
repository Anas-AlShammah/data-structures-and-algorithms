using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AnimalShelter
    {
        private CustomQueue<Animal> animalQueue;

        public AnimalShelter()
        {
            animalQueue = new CustomQueue<Animal>();
        }

        public void Enqueue(Animal animal)
        {
            animalQueue.Enqueue(animal);
        }

        public Animal Dequeue(string pref)
        {
            if (pref != "dog" && pref != "cat")
            {
                return null;
            }

            Animal result = null;
            CustomQueue<Animal> tempQueue = new CustomQueue<Animal>();

            while (!animalQueue.IsEmpty())
            {
                Animal animal = animalQueue.Dequeue();
                if (animal.Species == pref)
                {
                    result = animal;
                    break;
                }

                tempQueue.Enqueue(animal);
            }

            while (!tempQueue.IsEmpty())
            {
                animalQueue.Enqueue(tempQueue.Dequeue());
            }

            return result;
        }
    }

}
