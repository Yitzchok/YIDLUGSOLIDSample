namespace Samples.ISP
{
    public interface IDevice
    {
        void Draw();
        void OnHomeButtonDown();
        void OnBackButtonDown();
        void OnMenuButtonDown();
    }

    class AndroidHtcOne : IDevice
    {
        public void Draw()
        {
            //do action
        }

        public void OnHomeButtonDown()
        {
            //do action
        }

        public void OnBackButtonDown()
        {
            //do action
        }

        public void OnMenuButtonDown()
        {
            //do action
        }
    }

    public class iPhone : IDevice
    {
        public void Draw()
        {
            //do action
        }

        public void OnHomeButtonDown()
        {
            //do action
        }

        public void OnBackButtonDown()
        {
            //we don't have a back button
            throw new System.NotImplementedException();
        }

        public void OnMenuButtonDown()
        {
            //we don't have a menu button
            throw new System.NotImplementedException();
        }
    }
}