  public class ImageGallery
    {

        public void Share(Gmail mail)
        {
            mail.Send();

        }
    }

    public class Gmail
    {
        public void Send() { }
    }
    public class WhatsUp
    {
        public void Send() { }
    }
    public class Bluetooth
    {
        public void Send() { }
    }
    public class Entrypoint
    {
        public static void Main()
        {
            Gmail _mailAccount = new Gmail();
            ImageGallery _imageGallery = new ImageGallery();
            _imageGallery.Share(_mailAccount);

            Bluetooth _blueToothDevice = new Bluetooth();
            _imageGallery.Share(_blueToothDevice);

            WhatsUp _messanger = new WhatsUp();
            _imageGallery.Share(_messanger);

        }
    }
