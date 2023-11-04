using System.Text;

namespace SwitchController.Switch
{
    public class Commands
    {
        public static byte[] Click(Buttons.SwitchButton b)
        {
            var parser = b.ToString().ToUpper();
            parser += "\r\n";
            return Encoding.ASCII.GetBytes($"click {parser}");
        }
        public static byte[] Hold(Buttons.SwitchButton b)
        {
            var parser = b.ToString().ToUpper();
            parser += "\r\n";
            return Encoding.ASCII.GetBytes($"press {parser}");
        }
        public static byte[] Release(Buttons.SwitchButton b)
        {
            var parser = b.ToString().ToUpper();
            parser += "\r\n";
            return Encoding.ASCII.GetBytes($"release {parser}");
        }

    }
}
