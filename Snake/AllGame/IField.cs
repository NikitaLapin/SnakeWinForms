using System.Windows.Forms;

namespace Snake.AllGame
{
    public interface IField
    {
        void NewUpdate(KeyPressEventArgs e);
        void SetUp();
    }
}