sharp
using System;

namespace novela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine($"Здравствуй, {name}! \nТы встал рано утром и увидел, что окно разбито. Что будешь делать?");

            while (true) // Бесконечный цикл
            {
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1: Вызову полицию");
                Console.WriteLine("2: Спрячусь под кровать");
                Console.WriteLine("3: Пойду проверю");
                Console.WriteLine("4: Сдаться и закончить игру");

                string action_1_str = Console.ReadLine();
                byte action_1;

                if (!byte.TryParse(action_1_str, out action_1))
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 4.");
                    continue; // Возвращаемся к началу цикла
                }


                switch (action_1)
                {
                    case 1:
                        Console.WriteLine("Вы начали звонить в полицию, но связи нет...\nЧто-то упало на кухне. Ваши действия?");
                        Console.WriteLine("1: Убежать из дома");
                        Console.WriteLine("2: Пойти на кухню");

                        string run_attack_str = Console.ReadLine();
                        byte run_attack;
                         if (!byte.TryParse(run_attack_str, out run_attack))
                         {
                                 Console.WriteLine("Некорректный ввод. Пожалуйста, введите число 1 или 2.");
                                 continue;
                         }

                        if (run_attack == 1)
                        {
                            Console.WriteLine("Вы начали бежать, но дверь закрыта. Что будете делать?");
                            Console.WriteLine("1: Выбью дверь");
                            Console.WriteLine("2: Вылезу в разбитое окно");

                            string open_or_no_str = Console.ReadLine();
                            byte open_or_no;
                            if (!byte.TryParse(open_or_no_str, out open_or_no))
                            {
                                 Console.WriteLine("Некорректный ввод. Пожалуйста, введите число 1 или 2.");
                                 continue;
                            }

                            if (open_or_no == 1)
                            {
                                Console.WriteLine("Вы выбили дверь, но повредили ногу, но все же смогли сбежать. Хэппи хэппи хэппи! (Концовка 1)");
                                return; // Завершение игры
                            }
                            else
                            {
                                Console.WriteLine("Вы пошли к окну, но вас увидел грабитель...\nНо тут вдруг включились сирены и он начал убегать ничего не взяв с собой. Хэппи хэппи! (Концовка 2)");
                                return; // Завершение игры
                            }
                        }
                        else
                        {
                            Console.WriteLine("Вы увидели человека. Что будете делать?");
                            Console.WriteLine("1: Нападу");
                            Console.WriteLine("2: Попробовать решить мирно");

                            string atack_str = Console.ReadLine();
                            byte atack;
                             if (!byte.TryParse(atack_str, out atack))
                             {
                                 Console.WriteLine("Некорректный ввод. Пожалуйста, введите число 1 или 2.");
                                 continue;
                             }

                            if (atack == 1)
                            {
                                Console.WriteLine($"Вы напали на грабителя, но у него был пистолет и вы умерли. Press F вы достигли {age} лет. (Концовка 3: Плохая)");
                                return; // Завершение игры
                            }
                            else
                            {
                                Console.WriteLine("Вы решили проблемы мирно и выжили, но вас ограбили :(. (Концовка 4: Нейтральная)");
                                return; // Завершение игры
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("Вы спрятались под кроватью.");
                        Console.WriteLine("Вы очень сильно захотели в туалет, пойдете?\n1: Пойду\n2: Нет");

                        string toulet_str = Console.ReadLine();
                        byte toulet;
                         if (!byte.TryParse(toulet_str, out toulet))
                         {
                                 Console.WriteLine("Некорректный ввод. Пожалуйста, введите число 1 или 2.");
                                 continue;
                         }


                        if (toulet == 1)
                        {
                            Console.WriteLine("Вы пошли в туалет и вас ударили по голове сзади...\nВы очнулись в больнице и вас начали расспрашивать о грабителе. (Концовка 5)");
                            return; // Завершение игры
                        }
                        else
                        {
                            Console.WriteLine("Вы не пошли в туалет и просто ждали\nПозже вы все таки решили выйти.");
                            Console.WriteLine("Куда пойдете?\n1: Кухня\n2: Гостиная");

                            string lets_go_str = Console.ReadLine();
                            byte lets_go;
                             if (!byte.TryParse(lets_go_str, out lets_go))
                             {
                                 Console.WriteLine("Некорректный ввод. Пожалуйста, введите число 1 или 2.");
                                 continue;
                             }

                            if (lets_go == 1)
                            {
                                Console.WriteLine("Вы зашли на кухню и увидели котика, это был он злым грабителем. (Концовка 6: Странная)");
                                return; // Завершение игры
                            }
                            else
                            {
                                Console.WriteLine("Вы вышли и увидели странные следы на ковре и вы пошли на кухню");
                                Console.WriteLine("Вы зашли на кухню и увидели котика, это был он злым грабителем. (Концовка 7: Очень странная)");
                                return; // Завершение игры
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Вы вышли, прошли проверить и увидели человека. Что будете делать?");
                        Console.WriteLine("1: Нападу");
                        Console.WriteLine("2: Убегу");

                        string run_attack2_str = Console.ReadLine();
                        byte run_attack2;

                         if (!byte.TryParse(run_attack2_str, out run_attack2))
                         {
                                 Console.WriteLine("Некорректный ввод. Пожалуйста, введите число 1 или 2.");
                                 continue;
                         }

                        if (run_attack2 == 1)
                        {
                             Console.WriteLine("Вы напали на грабителя\n\nВы нанесли первый удар, но тут сразу вам дали в ответ, но в конце концов вы выйграли эту битву и вызвали полицию\nхэпи хэпи хэпи (Концовка 8: Героическая)");
                             return;

                        }
                        else
                        {
                            Console.WriteLine("Вы побежали и споткнулись и отрубились, когда очнулись, то поняли что вы перепили и у вас была белочка \nХэпи или не хэпи решать вам (Концовка 9: Глючная)");
                            return;
                        }

                    case 4:
                        Console.WriteLine("Вы решили сдаться. Игра окончена. (Концовка 10: Капитуляция)");
                        return; // Завершение игры

                    default:
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 4.");
                        break; // Возвращаемся к началу switch
                }
            }
        }
    }
}
