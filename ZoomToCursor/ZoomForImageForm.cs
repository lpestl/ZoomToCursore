using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZoomToCursor
{
    public partial class ZoomForImageForm : DevExpress.XtraEditors.XtraForm
    {
        // Оригинал картинки
        private Image imgOrigin;
        // Graphics созданный из pictureEditZoom
        private Graphics graph;
        // Хранит текущий размер картинки
        private double currentSizeW;
        private double currentSizeH;
        // Хранит координаты картинки
        private double currentPointX;
        private double currentPointY;
        // Zoom линейный. Зависит от размера изображения и от этого коэффициента зума
        public double kZoom = 10.0f;
        // Cоотношения сторон картинки-оригинала
        private double ratio;

        public ZoomForImageForm()
        {
            InitializeComponent();

            // Инициализация вспомогательных переменных
            imgOrigin = pictureEditZoom.Image;

            currentSizeW = pictureEditZoom.Image.Size.Width;
            currentSizeH = pictureEditZoom.Image.Size.Height;

            ratio = currentSizeW / currentSizeH;

            currentPointX = (currentSizeW - pictureEditZoom.Width) / 2 * (-1);
            currentPointY = (currentSizeH - pictureEditZoom.Height) / 2 * (-1);
        }

        // Добавить к pictureEdit событие MouseWheel
        private void pictureEdit1_Properties_MouseWheel_1(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Mouse pos (x:{0}, y:{1}) Wheel delta:{2}", e.X, e.Y, e.Delta);

            double lastSizeW = currentSizeW;
            double lastSizeH = currentSizeH;
            
            // Здесь можно всяко разно поизвращаться со способами зума
            currentSizeW += currentSizeW / e.Delta * kZoom;
            currentSizeH += currentSizeH / e.Delta * kZoom;

            // Для сохранения соотношения сторон при маленьком размере
            if (currentSizeW < 1)
            {
                currentSizeW = 1;
                currentSizeH = currentSizeW / ratio;
            }
            if (currentSizeH < 1)
            {
                currentSizeH = 1;
                currentSizeW = currentSizeH * ratio;
            }

            // Разница в размерах
            double deltaW = lastSizeW - currentSizeW;
            double deltaH = lastSizeH - currentSizeH;
            // Считаем новый сдвиг картинки, относительно курсора мышки
            currentPointX += deltaW * (e.X - currentPointX) / lastSizeW;
            currentPointY += deltaH * (e.Y - currentPointY) / lastSizeH;
            // Обновляем картинку
            pictureEditZoom.Refresh();
        }

        // Добавляем pictureEdit обработчик собития Paint
        private void pictureEditZoom_Paint(object sender, PaintEventArgs e)
        {
            // Получаем графику в pictureEdit
            graph = e.Graphics;
            // Очищаем
            graph.Clear(pictureEditZoom.BackColor);
            // Создаем новую картинку из оригинала с новыми размерами
            Bitmap bmp = new Bitmap(imgOrigin, new Size((int)currentSizeW, (int)currentSizeH));
            // Рисуем по сдвигу, относительно курсора
            graph.DrawImage(bmp, new Point((int)currentPointX, (int)currentPointY));
        }
    }
}
