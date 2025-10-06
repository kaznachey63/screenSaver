namespace screenSaver
{
    internal class Core
    {
        private List<Snowflake> snowflakes = new List<Snowflake>();
        private readonly Random random = new Random();
        private readonly int screenHeight = Screen.PrimaryScreen!.Bounds.Height;
        private readonly int screenWidth = Screen.PrimaryScreen!.Bounds.Width;

        /// <summary>
        /// Конструктор ядра программы
        /// </summary>
        /// <param name="givenAmount">Полученное количество</param>
        /// <param name="MainForm">Главная форма</param>
        public Core(int givenAmount)
        {
            GenerateSnowflakes(givenAmount);
        }

        /// <summary>
        /// Генерация снежинок
        /// </summary>
        /// <param name="amount">Количество снежинок</param>
        private void GenerateSnowflakes(int amount)
        {
            Image snowflakeImg = Properties.Resources.snowflake;

            for (int i = 0; i < amount; i++)
            {
                int newDX = random.Next(0, screenWidth);
                int newDY = random.Next(-screenHeight, -10);
                int speed = random.Next(25, 75);

                Snowflake snowflake = new Snowflake
                {
                    Image = snowflakeImg,
                    Speed = speed,
                    X = newDX,
                    Y = newDY,
                    Width = 35,
                    Height = 35
                };

                snowflakes.Add(snowflake);
            }
        }

        /// <summary>
        /// Отображение снежинок
        /// </summary>
        /// <param name="e">Событие отрисовки</param>
        public void ShowSnoflakes(PaintEventArgs e)
        {
            foreach (var snowflake in snowflakes)
            {
                if (snowflake.Image != null)
                {
                    e.Graphics.DrawImage(snowflake.Image, snowflake.X, snowflake.Y, snowflake.Width, snowflake.Height);
                }
            }
        }

        /// <summary>
        /// Смещение снежинки
        /// </summary>        
        public void OffsetSnowflake()
        {
            foreach (var snowflake in snowflakes)
            {
                int DX = snowflake.X;
                int newDY = snowflake.Y + snowflake.Speed;

                if (newDY > screenHeight)
                {
                    newDY = random.Next(-100, -20);
                    DX = random.Next(0, screenWidth);
                }

                snowflake.X = DX;
                snowflake.Y = newDY;
            }
        }
    }
}