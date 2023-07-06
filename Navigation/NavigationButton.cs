using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Navigation
{
    class NavigationButton
    {
        List<Button> buttons;
        Color defaultColor;
        Color seletedColor;

        public NavigationButton(List<Button> button, Color defaultColor, Color seletedColor)
        {
            this.buttons = button;
            this.defaultColor = defaultColor;
            this.seletedColor = seletedColor;
        }

        private void SetButtonColor()
        {
            foreach (Button button in buttons)
            {
                button.BackColor = defaultColor;
            }
        }

        public void selectedButton(Button selectedButton)
        {
            foreach (Button button in buttons)
            {
                if (button == selectedButton)
                {
                    selectedButton.BackColor = seletedColor;
                }
                else
                {
                    button.BackColor = defaultColor;
                }

            }
        }

    }
}
