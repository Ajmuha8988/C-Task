**Задача 1**

Заданы a и b. Выведите a+b.


Входные данные
В единственной строке входных данных заданы целочисленные a и b (1 ≤ a,b ≤ 1000).


Выходные данные
Выведите a+b.

**Задача 2**

Задано n целых чисел. Выведите их сумму.


Входные данные
В первой строке задано целое число n (1 ≤ n ≤ 10000). Вторая строка содержит n целых чисел, каждое от 1 до 10000, включительно.


Выходные данные
Выведите искомую сумму.

**Задача 3**

Альтернированной суммой заданной последовательности n чисел a1, a2,..., an называется число s=a1-a2+a3-a4+.... В альтернированной сумме знаки слагаемых чередуются, альтернация начинается со знака "+".

По заданной последовательности целых чисел выведите ее альтернированную сумму.


Входные данные
В первой строке задано целое число n (1 ≤ n ≤ 10000). Вторая строка содержит n целых чисел, каждое от 1 до 10000 включительно.


Выходные данные
Выведите искомую альтернированную сумму.

**Задача 4**

Задан номер года y. Ваша задача вывести 1, если год високосный. Выведите 0 в противном случае.

Год является високосным, если он кратен 4 и при этом не кратен 100, либо кратен 400. Так, годы 1700, 1800 и 1900 не были високосными, так как они кратны 100 и не кратны 400. Год 2000 — високосный, так как он кратен 400. 2100, 2200 и 2300 — не високосные.


Входные данные
В первой строке задано целое число y (1000 ≤ y ≤ 2100).


Выходные данные
Выведите 0 или 1 в соответствии с условием задачи.

**Задача 5**

Заданы n целых чисел. Выведите индекс (позицию) первого из минимальных элементов последовательности. Элементы последовательности занумерованы от 1 слева направо.


Входные данные
В первой строке записано целое число n (1 ≤ n ≤ 10000). Вторая строка содержит последовательность целых чисел a1, a2,..., an (-10000 ≤ ai ≤ 10000).


Выходные данные
Выведите искомый индекс.

**Задача 6**

В Бадене используют дюймы и футы. Для перевода длины из сантиметров достаточно знать, что в Бадене один дюйм равен трем сантиметрам, а один фут содержит 12 дюймов.

Задана длина равная n сантиметрам. Ваша задача перевести ее в футы и дюймы так, чтобы количество футов было максимально. Ответ должен быть целочисленным, округленным к ближайшему значению, содержащему целое число дюймов.

Пояснение к правилам округления: 1 см округляется к 0 дюймов, в то время как 2 см округляются до 1 дюйма.


Входные данные
В единственной строке записано целое число n (1 ≤ n ≤ 10000).


Выходные данные
Выведите два целых неотрицательных числа a и b через пробел, где a — количество футов, а b — количество дюймов.

**Задача 7**

При записи в двоичной системе счисления число будет заканчиваться на 0, если оно является четным. Аналогично, число будет заканчиваться на два нуля, если оно делится на 4.

В этой задаче вам надо определить "круглость" числа при записи в двоичной системе счисления, т.е. вам необходимо найти максимальную степень двойки, на которую это число делится.

Напишите программу, которая определяет на сколько нулей оканчивается двоичная запись заданного целого числа n.


Входные данные
В единственной строке записано целое число n (1 ≤ n ≤ 109).


Выходные данные
Выведите искомое количество нулей.

**Задача 8**

Задана грузоподъемность грузовика w (в тоннах). На него последовательно грузятся предметы массами a1, a2,..., an, где ai — масса i-го груза в тоннах. Если при погрузке очередного предмета рабочие замечают, что в случае завершения процесса суммарный вес погруженных предметов превысит грузоподъемность, то погрузка этого предмета не осуществляется (он пропускается).

Выведите количество предметов, которые будут погружены в соответствии с алгоритмом выше и их суммарную массу.


Входные данные
В первой строке записана пара целых чисел n, w (1 ≤ n ≤ 10000, 1 ≤ w ≤ 10000). Вторая строка содержит последовательность целых чисел a1, a2,..., an (1 ≤ ai ≤ 10000).


Выходные данные
Выведите количество погруженных предметов и их суммарную массу.


**Задача 9**

Задана последовательность n целых чисел a1, a2,..., an. Выведите сумму всех ее элементов, стоящих на позициях, которые являются степенями двойки: 1, 2, 4, 8, 16 и т.д.


Входные данные
В первой строке задано целое число n (1 ≤ n ≤ 10000). Вторая строка содержит последовательность целых чисел a1, a2,..., an.


Выходные данные
Выведите искомую сумму.


**Задача 10**

Наибольшим общим делителем (НОД) для двух целых чисел m и n называется наибольший из их общих делителей. Например, для чисел 70 и 105 наибольший общий делитель равен 35.

С давних времен известен следующий алгоритм нахождения наибольшего общего делителя двух неотрицательных целых чисел: пока оба числа строго положительны надо из большего числа вычесть меньшее. Результатом работы (наибольшим общим делителем) является большее число после окончания описанной серии вычитаний или 0, если оба числа в конце равны 0.

Вам заданы целые неотрицательные a и b (0 ≤ a,b ≤ 107). Напишите программу, которая выведет количество вычитаний при работе такого алгоритма и результат его работы.


Входные данные
Единственная строка входных данных содержит записанные через пробел целые числа a, b (0 ≤ a,b ≤ 107).


Выходные данные
Выведите количество вычитаний в ходе работы алгоритма и его результат через пробел.


**Задача 11**

Задан возраст человека — число n. Ваша задача написать программу, которая классифицирует человека по его возрасту.
Если это число меньше 7, то обычно это означает, что задан дошкольник и надо вывести "preschool child".
Если это число от 7 до 17, то обычно это означает, что задан школьник и надо вывести "schoolchild m", где m — это его предполагаемый класс (число от 1 до 11, считайте, что учатся в школе с 7 лет, класс меняется раз в год).
Если это число от 18 до 22, то обычно это означает, что задан студент и надо вывести "student m", где m — это его предполагаемый курс (число от 1 до 5, считайте, что учатся в университете с 18 лет, курс меняется раз в год).
Если это число больше 22, то выведите "specialist", что означает квалификацию "специалист".



Входные данные
В единственной строке задано целое число n (0 ≤ n ≤ 150).


Выходные данные
Выведите искомую строку.


**Задача 12**

Верно ли, что два заданных прямоугольника a1 x b1 и a2 x b2 были получены разрезанием некоторого квадрата одним прямолинейным разрезом? Напишите программу, которая выведет YES или NO.


Входные данные
В первой строке заданы числа целые a1, b1 (1 ≤ a1,b1 ≤ 1000), во второй — числа целые a2, b2 (1 ≤ a2,b2 ≤ 1000). Числа в строках заданы через пробел.


Выходные данные
Выведите YES или NO.


**Задача 13**

Задана последовательность n целых чисел a1, a2,..., an. Выведите количество ее элементов, равных минимальному.


Входные данные
В первой строке записано целое число n (1 ≤ n ≤ 10000). Вторая строка содержит последовательность n целых чисел a1, a2,..., an (-10000 ≤ ai ≤ 10000).


Выходные данные
Выведите искомое количество минимумов.


**Задача 14**

Наибольшим общим делителем (НОД) для двух целых чисел m и n называется наибольший из их общих делителей. Например, для чисел 70 и 105 наибольший общий делитель равен 35.

С давних времен известен следующий алгоритм нахождения наибольшего общего делителя двух неотрицательных целых чисел: пока оба числа строго положительны надо из большего числа вычесть меньшее. Результатом работы (наибольшим общим делителем) является большее число после окончания описанной серии вычитаний или 0, если оба числа в конце равны 0.

Вам заданы целые неотрицательные a и b (0 ≤ a,b ≤ 109). Напишите программу, которая выведет количество вычитаний при работе такого алгоритма и результат его работы.


Входные данные
Единственная строка входных данных содержит записанные через пробел целые числа a, b (0 ≤ a,b ≤ 109).


Выходные данные
Выведите количество вычитаний в ходе работы алгоритма и его результат через пробел.


**Задача 15**

Простое число — это натуральное число, которое имеет ровно два различных натуральных делителя: единицу и самого себя. Последовательность простых чисел начинается так: 2, 3, 5, 7, 11, 13, 17, 19, 23,...

Напишите программу, которая выведет все простые числа на отрезке [1,n] в порядке возрастания.


Входные данные
В единственной строке входных данных записано целое число n (1 ≤ n ≤ 10000).


Выходные данные
Выведите все простые числа на отрезке [1,n] по возрастанию по одному в строке.


**Задача 16**

Задано уравнение вида Ax2+Bx+C=0. В этом уравнении каждый коэффициент может принимать любое значение от -100 до 100, включительно. Такое уравнение может иметь 0, 1, 2 или даже бесконечное количество различных корней.

Напишите программу, которая выведет количество корней этого уравнения.


Входные данные
Единственная строка входных данных содержит целые числа A, B, C (-100 ≤ A,B,C ≤ 100).


Выходные данные
Выведите количество корней или число -1, если уравнение имеет бесконечное количество корней.


**Задача 17**

Вам задана пара целых чисел a, b (1 ≤ a ≤ b ≤ 5000). Выведите все числа из отрезка [a,b], которые имеют наибольшее количество делителей из всех чисел в этом отрезке.


Входные данные
В единственной строке входных данных заданы числа a, b (1 ≤ a ≤ b ≤ 5000).


Выходные данные
В первую строку выведите количество найденных чисел. Во вторую строку выведите сами числа, числа разделяйте запятыми (без каких-либо пробелов). Запятую после последнего числа выводить не надо (см. примеры).


**Задача 18**

Задана последовательность n чисел a1, a2,..., an. Для нее вычисляется "хитрая" сумма: s=+a1-a2-a3+a4+a5+a6-a7-a8-a9-a10+..., т.е. знаки плюс и минус чередуются блоками, длина i-го блока равна i.

Выведите "хитрую" сумму заданной последовательности.


Входные данные
В первой строке задано целое число n (1 ≤ n ≤ 10000). Далее во второй строке задана последовательность a1, a2,..., an (1 ≤ ai ≤ 10000).


Выходные данные
Выведите "хитрую" сумму заданной последовательности.


**Задача 19**

Книжная полка имеет треугольную форму: на ее верхней полке помещается одна книга, на второй — две, на третьей — три и т.д. (на i-ой помещается i книг).

Все книги занумерованы по полкам сверху вниз, а на одной полке — слева направо. То есть единственная книга на верхней полке имеет номер 1, на второй полке — книги 2 и 3, а на третьей — 4, 5 и 6.

Задан номер книги n, необходимо вывести номер полки, на которой она находится.


Входные данные
В единственной строке входных данных записано целое число n (1 ≤ n ≤ 108).


Выходные данные
Выведите номер полки, на которой находится книга с номером n.


**Задача 20**

Задана последовательность a1, a2,..., an, которая отсортирована по неубыванию. Выведите наиболее часто встречающееся в ней значение и количество его появлений в последовательности.


Входные данные
В первой строке задано целое число n (1 ≤ n ≤ 10000). Вторая строка содержит n целых чисел, каждое от 1 до 10000 включительно. Заданная последовательность отсортирована по неубыванию.


Выходные данные
Выведите два целых числа f, c (числа разделяйте пробелом), где f — значение наиболее часто встречающегося элемента последовательности и c — количество его появлений. Если существует несколько возможных значений для f, то выведите наименьшее из них.
