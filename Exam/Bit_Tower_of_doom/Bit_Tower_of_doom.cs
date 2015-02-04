using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bit_Tower_of_doom
{
    static void Main()
    {
        Console.Write("Enter kights in chariot 1: ");
        int floor0 = int.Parse(Console.ReadLine());
        Console.Write("Enter kights in chariot 2: ");
        int floor1 = int.Parse(Console.ReadLine());
        Console.Write("Enter kights in chariot 3: ");
        int floor2 = int.Parse(Console.ReadLine());
        Console.Write("Enter kights in chariot 4: ");
        int floor3 = int.Parse(Console.ReadLine());
        Console.Write("Enter kights in chariot 5: ");
        int floor4 = int.Parse(Console.ReadLine());
        Console.Write("Enter kights in chariot 6: ");
        int floor5 = int.Parse(Console.ReadLine());
        Console.Write("Enter kights in chariot 7: ");
        int floor6 = int.Parse(Console.ReadLine());
        Console.Write("Enter kights in chariot 8: ");
        int floor7 = int.Parse(Console.ReadLine());
        int knightsArrive = 0;
        int knightSurvive = 0;
        int mask;
        const string END_COMMAND = "end";
        const string SELECT_COMMAND = "select";
        const string KILL_COMMAND = "kill";
        const int CHARIOT_SEATS_COUNT = 8;
        const int GAME_FIELD_WIDTH = 8;
        for (int i = 0; i < CHARIOT_SEATS_COUNT; i++)
        {
            mask = 1 << i;
            if((floor0 & mask)>0)
            {
                knightsArrive++;
            }
            if ((floor1 & mask) > 0)
            {
                knightsArrive++;
            }
            if ((floor2 & mask) > 0)
            {
                knightsArrive++;
            }
            if ((floor3 & mask) > 0)
            {
                knightsArrive++;
            }
            if ((floor4 & mask) > 0)
            {
                knightsArrive++;
            }
            if ((floor5 & mask) > 0)
            {
                knightsArrive++;
            }
            if ((floor6 & mask) > 0)
            {
                knightsArrive++;
            }
            if ((floor7 & mask) > 0)
            {
                knightsArrive++;
            }
        }
        knightSurvive = knightsArrive;
        while(true)
        {
            string command = Console.ReadLine();
            if(command==END_COMMAND)
            {
                break;
            }
            bool select = command == SELECT_COMMAND;
            int currentFloorNumber = int.Parse(Console.ReadLine());
            int position = (GAME_FIELD_WIDTH - 1) - int.Parse(Console.ReadLine());
            int currentFloor = 0;
            switch (currentFloorNumber)
            {
                case 0:
                    currentFloor = floor0;
                    break;
                case 1:
                    currentFloor = floor1;
                    break;
                case 2:
                    currentFloor = floor2;
                    break;
                case 3:
                    currentFloor = floor3;
                    break;
                case 4:
                    currentFloor = floor4;
                    break;
                case 5:
                    currentFloor = floor5;
                    break;
                case 6:
                    currentFloor = floor6;
                    break;
                case 7:
                    currentFloor = floor7;
                    break;
            }
            mask = 1 << position;
            if(select)
            {
                currentFloor = currentFloor ^ mask;
            }
            else
            {
                if(position>0&&position<GAME_FIELD_WIDTH)
                {
                    bool difender = (currentFloor & mask) > 0;
                    bool kill = command == KILL_COMMAND;
                    if(difender)
                    {
                        knightSurvive--;
                        continue;
                    }
                    bool leftdefender = false;
                    bool rightdefender = false;
                    if(position<GAME_FIELD_WIDTH-1)
                    {
                        mask = 1 << (position + 1);
                        leftdefender = (currentFloor & mask) > 0;
                    }
                    if(position>0)
                    {
                        mask = 1 << (position - 1);
                        rightdefender = (currentFloor & mask) > 0;
                    }
                    if(leftdefender&&rightdefender)
                    {
                        knightSurvive--;
                        continue;
                    }
                      if (leftdefender)
                    {
                        if (kill) // BOTH ATTACKER AND DEFENDER DIE
                        {
                            mask = 1 << (position + 1);
                            currentFloor = currentFloor ^ mask;

                            knightSurvive -= 2;
                        }
                        else // MOVING KNIGHT DIES BY THE LEFT DEFENDER'S HANDS
                        {
                            knightSurvive--;
                        }
                    }
                    else if (rightdefender)
                    {
                        if (kill) // BOTH ATTACKER AND DEFENDER DIE
                        {
                            mask = 1 << (position - 1);
                            currentFloor = currentFloor ^ mask;

                            knightSurvive -= 2;
                        }
                        else // MOVING KNIGHT DIES BY THE RIGHT DEFENDER'S HANDS
                        {
                            knightSurvive--;
                        }
                    }
                    else // NO GUARDIANS WERE FOUND, THE ATTACKER MOVES TO THE DESTINATION AND STAIS THERE
                    {
                        mask = (1 << position);
                        currentFloor = currentFloor | mask;
                    }
                }
                else
                {
                    if (currentFloorNumber > 1)
                    {
                        knightSurvive--;
                    }
                }
            }

            // UPDATES THE CURRENT FLOOR
            switch (currentFloorNumber)
            {
                case 0:
                    floor0 = currentFloor;
                    break;

                case 1:
                    floor1 = currentFloor;
                    break;

                case 2:
                    floor2 = currentFloor;
                    break;

                case 3:
                    floor3 = currentFloor;
                    break;

                case 4:
                    floor4 = currentFloor;
                    break;

                case 5:
                    floor5 = currentFloor;
                    break;

                case 6:
                    floor6 = currentFloor;
                    break;

                case 7:
                    floor7 = currentFloor;
                    break;
            }
        }

        int sum = floor0 + floor1 + floor2 + floor3 + floor4 + floor5 + floor6 + floor7;

        // PRINTING OUTPUT
        Console.WriteLine(knightsArrive);
        Console.WriteLine(knightSurvive);
        Console.WriteLine(sum);
    }
}