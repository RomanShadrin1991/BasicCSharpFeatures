namespace BasicCSharpFeatures
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {
        /// <summary>
        /// Ф.И.О
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Возраст
        /// </summary>
        public byte Age { get; set; }
        /// <summary>
        /// E-mail
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Баллы по программированию
        /// </summary>
        public float ProgrammingPoints { get; set; }
        /// <summary>
        /// Баллы по математике
        /// </summary>
        public float MathPoints { get; set; }
        /// <summary>
        /// Баллы по физике
        /// </summary>
        public float PhysicsPoints { get; set; }
        /// <summary>
        /// Создание нового пользователя
        /// </summary>
        /// <param name="fullName"> Ф.И.О </param>
        /// <param name="age"> Возраст </param>
        /// <param name="email"> e-mail </param>
        /// <param name="programmingPoints"> Баллы по программированию </param>
        /// <param name="mathPoints"> Баллы по математике </param>
        /// <param name="physicsPoints"> Баллы по физике </param>
        public User(string fullName, byte age, string email, float programmingPoints, float mathPoints, float physicsPoints)
        {
            FullName = fullName;
            Age = age;
            Email = email;
            ProgrammingPoints = programmingPoints;
            MathPoints = mathPoints;
            PhysicsPoints = physicsPoints;
        }
        public override string ToString()
        {
            return $"Ф.И.О: {FullName}" +
                   $"\nВозраст: {Age}" +
                   $"\n\tБаллы по программированию: {ProgrammingPoints}" +
                   $"\n\tБаллы по математике: {MathPoints}" +
                   $"\n\tБаллы по физике: {PhysicsPoints}";
        }
    }
}