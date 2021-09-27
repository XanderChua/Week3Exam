using System;
using System.Collections.Generic;

namespace Week3Q1
{
    public delegate void LotteryDelegate(string participantsName);
    class Participants
    {
        public string Name { get; private set; }
        public Participants(string name)
        {
            Name = name;
        }
    }
    class LotteryManager
    {
        private List<Participants> participantsList = new List<Participants>();
        public event LotteryDelegate participantsAdded;
        public event LotteryDelegate send;
        public string numbers;
        public List<Participants> GetParticipants()
        {
            return participantsList;
        }
        public void GenerateNumber()
        {
            Random random = new Random();
            string r1 = "";
            string r2 = "";
            string r3 = "";
            string r4 = "";
            string r5 = "";
            string r6 = "";
            string r7 = "";
            string r8 = "";
            string r9 = "";
            string r10 = "";
            string r11 = "";
            string r12 = "";

            r1 += random.Next(0, 9);
            r2 += random.Next(0, 9);
            r3 += random.Next(0, 9);
            r4 += random.Next(0, 9);
            r5 += random.Next(0, 9);
            r6 += random.Next(0, 9);
            r7 += random.Next(0, 9);
            r8 += random.Next(0, 9);
            r9 += random.Next(0, 9);
            r10 += random.Next(0, 9);
            r11 += random.Next(0, 9);
            r12 += random.Next(0, 9);
            string twelvedigitsrandom = r1 + r2 + r3 + r4 + r5 + r6 + r7 + r8 + r9 + r10 + r11 + r12;
            numbers = twelvedigitsrandom;
        }
        public void AddParticipants(string name)
        {
            Participants p = new Participants(name);
            participantsList.Add(p);
            participantsAdded?.Invoke(name);
        }
        public void Notify()
        {
            if(send != null)
            {
                send(numbers);
            }
        }
    }

    class LotterySubscribe //subscriber
    {
        public void SubscribeToEvent(LotteryManager lotteryManager)
        {
            lotteryManager.participantsAdded += LotteryManager_participantsAdded;
        }
        private void LotteryManager_participantsAdded(string participantsName)
        {
            Console.WriteLine("\nParticipant " + participantsName + " is added.\n");
        }
    }
    class Week3Q1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Exam Delegate Lottery--");          
            LotteryManager lotteryManager = new LotteryManager();
            LotterySubscribe lotterySubscribe = new LotterySubscribe();

            while (true)
            {
                Console.WriteLine("1. Add Participant and Generate Tickets");
                Console.WriteLine("2. View Participants and Tickets");
                Console.WriteLine("3. Generate Winner");
                int input = Int32.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {                         
                            Random random = new Random();
                            string r1 = "";
                            string r2 = "";
                            string r3 = "";
                            string r4 = "";
                            string r5 = "";
                            string r6 = "";
                            string r7 = "";
                            string r8 = "";
                            string r9 = "";
                            string r10 = "";
                            string r11 = "";
                            string r12 = "";

                            r1 += random.Next(0, 9);
                            r2 += random.Next(0, 9);
                            r3 += random.Next(0, 9);
                            r4 += random.Next(0, 9);
                            r5 += random.Next(0, 9);
                            r6 += random.Next(0, 9);
                            r7 += random.Next(0, 9);
                            r8 += random.Next(0, 9);
                            r9 += random.Next(0, 9);
                            r10 += random.Next(0, 9);
                            r11 += random.Next(0, 9);
                            r12 += random.Next(0, 9);
                            string twelvedigitsrandom = r1 + r2 + r3 + r4 + r5 + r6 + r7 + r8 + r9 + r10 + r11 + r12;

                            Console.WriteLine("Enter name to generate number:");
                            string name = Console.ReadLine() + " " + twelvedigitsrandom;
                            lotterySubscribe.SubscribeToEvent(lotteryManager);
                            lotteryManager.AddParticipants(name);                       
                            break;
                        }
                    case 2:
                        {
                            foreach (var participants in lotteryManager.GetParticipants())
                            {
                                Console.WriteLine(participants.Name);
                            }
                            break;
                        }
                    case 3:
                        {
                            if (lotteryManager.GetParticipants().Count < 10)
                            {
                                Console.WriteLine("Not enough participants for the draw.");
                                break;
                            }
                            else
                            {

                            }
                            break;
                        }
                }
            }
        }
    }
}
