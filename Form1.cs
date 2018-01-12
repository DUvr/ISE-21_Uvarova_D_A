using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
       private Potato[] potato;
        private Specii specii;
        private WaterTap waterTap;
        private Knife knife;
        private Pan pan;
        private Stove stove;
        private Luk luk;
        private Manti manti;
        
        private Testo[] testo;
        private Water water;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Функция, вызываемая при загрузки формы
        /// инициализурем здесь некоторые элементы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormKitchen_Load(object sender, EventArgs e)
        {
            waterTap = new WaterTap();
            knife = new Knife();
            pan = new Pan();
            stove = new Stove();
        }
        /// <summary>
        /// Открываем воду. Делаем доступными кнопки для мойки картошки или для заливания воды
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOpen.Checked)
            {
                waterTap.State = true;
            }
        }
        /// <summary>
        /// Закрываем воду
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonClose_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonClose.Checked)
            {
                waterTap.State = false;
            }
        }

        /// <summary>
        /// Мойка картошки. Первый этап готовки. Смотрим сколько есть картошки и делаем поле недоступным 
        /// для изменения, чтобы потом не добавлялись еще картошки
        /// Как помыли - можно чистить. И не забыть закрыть кран, чтоб вода не текла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWash_Click(object sender, EventArgs e)
        {
            if (numericUpDownPotatos.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                potato = new Potato[Convert.ToInt32(numericUpDownPotatos.Value)];
                pan.Init(Convert.ToInt32(numericUpDownPotatos.Value));
                for (int i = 0; i < potato.Length; ++i)
                {
                    potato[i] = new Potato();
                }
                for (int i = 0; i < potato.Length; ++i)
                {
                    potato[i].Dirty = 0;
                }
                numericUpDownPotatos.Enabled = false;
                radioButtonClose.Checked = true;
                MessageBox.Show("Картошку помыли, можно чистить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Картошки то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Чистим картошку. Как почистили - можно заливать воду в кастрюлю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearPotatos_Click(object sender, EventArgs e)
        {
            if (potato == null)
            {
                MessageBox.Show("Картошки то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (potato.Length == 0)
            {
                MessageBox.Show("Картошки то нет, что чистить?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < potato.Length; ++i)
            {
                if (potato[i].Dirty > 0)
                {
                    MessageBox.Show("Картошка грязная!!! Помыть бы ее сначала, а уж потом чистить", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < potato.Length; ++i)
            {
                knife.Clean_and_Rezka(potato[i]);
            }

            buttonAddSalt.Enabled = true;
            buttonAddLuk.Enabled = true;
            buttonAddPotatos.Enabled = true;
            MessageBox.Show("Картошку почистили и порезали, можно добавлять в начинку", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void buttonRezkaTesto_Click(object sender, EventArgs e)
        {
            if (testo == null)
            {
                MessageBox.Show("теста то нет, что резать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (testo.Length == 0)
            {
                MessageBox.Show("теста то нет, что резать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            for (int i = 0; i < testo.Length; ++i)
            {
                knife.Have_parts(testo[i]);
            }
           
            
            MessageBox.Show("Тесто разделили,можно лепить манты", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void buttonAddLuk_Click(object sender, EventArgs e)
        {
            luk = new Luk();
            luk.Count = Convert.ToInt32(numericUpDownLuk.Value);
            if (luk.Count > 0)
            {
                manti.AddLuk(luk);
                MessageBox.Show("Лук добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Лука же нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }



        private void buttonAddSalt_Click(object sender, EventArgs e)
        {
            specii = new Specii();
            specii.Count = Convert.ToInt32(numericUpDownSalt.Value);
            if (specii.Count > 0)
            {
                manti.AddPriprava(specii);
                MessageBox.Show("Соль добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Соли же нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void buttonAddPotato_Click(object sender, EventArgs e)
        {
            if (potato == null)
            {
                MessageBox.Show("Картошки то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (potato.Length == 0)
            {
                MessageBox.Show("Картошки то нет, что варить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < potato.Length; ++i)
            {
                if (potato[i].Dirty > 0)
                {
                    MessageBox.Show("Картошка грязная!!! Какой ее варить, а ну мыть ее быстро!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (potato[i].Have_skin)
                {
                    MessageBox.Show("У нас обычная картошка, не в мундире. Надо почистить!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < potato.Length; ++i)
            {
                manti.AddPotato(potato[i]);
            }
            
            buttonAddTesto.Enabled = true;
            
            MessageBox.Show("Картошку положили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void buttonAddTesto_Click(object sender, EventArgs e)
        {
            if (testo == null)
            {
                MessageBox.Show("теста то нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (testo.Length == 0)
            {
                MessageBox.Show("теста то нет", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < testo.Length; ++i)
            {
                
                if (testo[i].Have_parts)
                {
                    MessageBox.Show("тесто не разделено", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < testo.Length; ++i)
            {
                manti.AddTesto(testo[i]);
            }
            
        }


      



        private void buttonAddManti_Click(object sender, EventArgs e)
        {
            manti = new Manti();
            manti.Count = Convert.ToInt32(numericUpDownManti.Value);
            if (manti.Count > 0)
            { 
                pan.AddManti(manti);
                MessageBox.Show("манты добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("мантов же нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buttonAddPan.Enabled = true;
        }



        /// <summary>
        /// Заливаем воду в кастрюлю
        /// Как зальем - можно сыпать соль. Опять не забываем закрыть воду

        private void buttonAddWater_Click(object sender, EventArgs e)
        {
            if (!waterTap.State)
            {
                MessageBox.Show("Кран закрыт, как заливать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < 3; ++i)
            {
                pan.AddWater(waterTap.GetWater());
            }
            
            radioButtonClose.Checked = true;
            MessageBox.Show("Воду залили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
       
        
        
        private void buttonAddPan_Click(object sender, EventArgs e)
        {
           
            stove.Pan = pan;
            buttonCook.Enabled = true;
            MessageBox.Show("Кастрюлька на плите", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Включаем/выключаем плиту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxOn_CheckedChanged(object sender, EventArgs e)
        {
            stove.State = checkBoxOn.Checked;
        }
        /// <summary>
        /// Проверка, что все готово к готовки и готовим
        /// Либо сготовится, либо что-то не получилось
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        /// <summary>
        /// Снимаем кастрюлю с плиты, можно сливать воду
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGetPan_Click(object sender, EventArgs e)
        {
            buttonDrain.Enabled = true;
            MessageBox.Show("Убрали с плиты", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Как слили -можно вынимать картошку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrain_Click(object sender, EventArgs e)
        {
            pan.Drain();
            buttonGetPotatos.Enabled = true;
            MessageBox.Show("Воду слили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Ням-ням
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonCook_Click(object sender, EventArgs e)
        {

        }
    } 

    }

