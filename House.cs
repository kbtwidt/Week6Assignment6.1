using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Week6Assignment6._1
{
    enum HouseType
    {
        Ranch = 1,
        Colonial,
        Cottage,
        Victorian,
        Contemporary
    }
    class HouseNode
    {
        public int HouseNumber;
        public string Address;
        public HouseType houseType;
        public HouseNode next;

        public HouseNode(int number, string address, HouseType type)
        {
            HouseNumber = number;
            Address = address;
            houseType = type;
            next = null;
        }
    }

    class HouseList
    {
        private HouseNode head;
        private HouseNode tail;
        private int size;
        public int Size { get { return size; } }
        public HouseList ()
        {
            head = null;
            tail = null;
            size = 0;
        }
        public bool IsEmpty()
        {
            return size == 0;
        }

        public void AddHouse(int number, string address, HouseType type, int position)
        {
            HouseNode newHouse = new HouseNode(number, address, type);

            if (position <= 0 || position > size + 1)
            {
                Console.WriteLine("Position is invalid.");
                return;
            }
            if (position == 1)
            {
                if (IsEmpty())
                {
                    this.head = newHouse;
                    this.tail = newHouse;
                }
                else
                {
                    newHouse.next = head;
                    this.head = newHouse;
                }
                size++;
                return;
            }
            if (position == size + 1)
            {
                if (IsEmpty())
                {
                    this.head = newHouse;
                    this.tail = newHouse;
                }
                else
                {
                    tail.next = newHouse;
                    this.tail = newHouse;
                }
                size++;
                return;
            }
            HouseNode tempHouse = head;
            int i = 1;
            while (i < position - 1)
            {
                tempHouse = tempHouse.next;
                i++;
            }
            newHouse.next = tempHouse.next;
            tempHouse.next = newHouse;
            size++;
        }
        public void RemovePostion(int position)
        {
            HouseNode tempHouse = head;
            int i;
            if (position <= 0 || position > size)
                Console.WriteLine("Position is invalid");
            if (position == 1)
            {
                if (IsEmpty())
                    Console.WriteLine("House list is empty");
                head = head.next;
                size--;
                if (IsEmpty())
                    tail = null;
            }
            if (position == size)
            {
                if (IsEmpty())
                    Console.WriteLine("House list is empty");
                i = 1;
                while (i < size - 1)
                {
                    tempHouse = tempHouse.next;
                    i++;
                }
                tail = tempHouse;
                tail.next = null;
                size--;
                if (IsEmpty())
                    head = null;
            }
            i = 1;
            while (i < position - 1)
            {
                tempHouse = tempHouse.next;
                i++;
            }
            tempHouse.next = tempHouse.next.next;
            size--;
        }
        public void SearchHouse(int number)
        {
            HouseNode current = head;

            while (current != null)
            {
                if (current.HouseNumber == number)
                {
                    Console.WriteLine("\nHouse Found!");
                    Console.WriteLine("House Number: " + current.HouseNumber);
                    Console.WriteLine("Address: " + current.Address);
                    Console.WriteLine("Type: " + current.houseType);
                    return;
                }

                current = current.next;
            }

            Console.WriteLine("House not found.");
        }
        public void Display()
        {
            HouseNode tempHouse = head;
            if(IsEmpty())
            {
                Console.WriteLine("List is empty.");
                return;
            }
            else
            {
                while (tempHouse != null)
                {
                    Console.WriteLine("House Number: " + tempHouse.HouseNumber);
                    Console.WriteLine("Address: " + tempHouse.Address);
                    Console.WriteLine("Type: " + tempHouse.houseType);
                    tempHouse = tempHouse.next;
                }
            }
        }
    }

}
