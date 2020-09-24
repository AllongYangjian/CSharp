namespace _3_单例模式
{
    /// <summary>
    /// 单例模式
    /// </summary>
    class SingletonTest
    {
        private static SingletonTest instance;

        private SingletonTest()
        {

        }

        public static SingletonTest GetInstance()
        {
            if(instance ==null)
            {
                instance = new SingletonTest();
            }
            return instance;
        }
    }
}