namespace screenSaver
{
    internal class Snowflake
    {
        /// <summary>
        /// Картинка снежинки
        /// </summary>
        public Image? Image { get; set; }

        /// <summary>
        /// Скорость падения снежинки в пикселях
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// Х координата снежинки
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// У координата снежинки
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Ширина снежинки 
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Высота снежинки
        /// </summary>
        public int Height { get; set; }
    }
}