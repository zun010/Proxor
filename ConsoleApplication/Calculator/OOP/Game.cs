using System;

namespace Proxor
{
    public class Game
    {
        private Player _player;
        
        public void Initialize()
        {
            _player = new Player();
        }
        public void Update(string command)
        {
            State state = _player.State;
            if (command == "идти")
            {
                switch (state)
                {
                    case State.Idle: 
                    case State.LootFound:
                        _player.GoForward();
                        break;
                    case State.InFight:
                        Console.WriteLine("Не можешь двигаться дальше пока сражаешься");
                        break;
                    case State.Dead:
                        Console.WriteLine("Вы мертвы");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
            }

            if (command == "атаковать")
            {
                switch (state)
                {
                    case State.Idle: 
                    case State.LootFound:
                        Console.WriteLine("Некого атаковать");
                        break;
                    case State.InFight:
                        _player.Attack();
                        break;
                    case State.Dead:
                        Console.WriteLine("Вы мертвы");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                
            }

            if (command == "убежать")
            { 
                switch (state)
                {
                    case State.Idle: 
                    case State.LootFound:
                        Console.WriteLine("Неоткого убегать");
                        break;
                    case State.InFight:
                        _player.RunAway();
                        break;
                    case State.Dead:
                        Console.WriteLine("Вы мертвы");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            if (command == "поднять")
            {
                switch (state)
                {
                    case State.Idle: 
                        Console.WriteLine("Лута нет");
                        break;
                    case State.InFight:
                        Console.WriteLine("Нельзя поднять лут пока сражаешься");
                        break;
                    case State.Dead:
                        Console.WriteLine("Вы мертвы");
                        break;
                    case State.LootFound:
                        _player.GetLoot();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            if (command == "инвентарь")
            {
                switch (state)
                {
                    case State.Idle: 
                    case State.LootFound:
                        _player.OpenBag();
                        break;
                    case State.InFight:
                        Console.WriteLine("Нельзя открыть инвентарь пока сражаешься");
                        break;
                    case State.Dead:
                        Console.WriteLine("Вы мертвы");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

            }

            if (command == "съесть")
            {
                switch (state)
                {
                    case State.Idle: 
                    case State.LootFound:
                        _player.EatFood();
                        break;
                    case State.InFight:
                        Console.WriteLine("Нельзя есть во время сражения");
                        break;
                    case State.Dead:
                        Console.WriteLine("Вы мертвы");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}