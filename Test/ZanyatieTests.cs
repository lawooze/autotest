using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace Test
{
    [TestClass] // Атрибут, указывающий, что это класс с тестами
    public class ZanyatieTests
    {
        [TestMethod] // Атрибут, указывающий, что это метод с тестом
        public void Constructor_ShouldInitializeFields()
        {
            // Arrange - подготовка данных для теста
            DateTime expectedDate = new DateTime(2024, 6, 1); // Ожидаемая дата проведения
            Disciplina disciplina = new Disciplina("Matematika", "Mat"); // Создание объекта дисциплины
            Sotrudnik sotrudnik = new Sotrudnik("Ivan", "Ivanov"); // Создание объекта сотрудника
            Auditoriya auditoriya = new Auditoriya("101"); // Создание объекта аудитории
            Gruppa gruppa = new Gruppa("Gruppa A", "GA", 30, 2023, "link", "boss"); // Создание объекта группы
            Para para = new Para(new DateTime(2024, 6, 1, 9, 0, 0), new DateTime(2024, 6, 1, 10, 30, 0), new DateTime(2024, 6, 1, 10, 30, 0), new DateTime(2024, 6, 1, 10, 45, 0)); // Создание объекта пары
            VidZanyatiya vidZanyatiya = new VidZanyatiya("Lektsiya"); // Создание объекта вида занятия

            // Act - выполнение тестируемого действия
            Zanyatie zanyatie = new Zanyatie(
                expectedDate,
                disciplina,
                sotrudnik,
                auditoriya,
                gruppa,
                para,
                vidZanyatiya
            );

            // Assert - проверка результата
            Assert.AreEqual(expectedDate, zanyatie.DataProvedeniya); // Проверка даты проведения
            Assert.AreEqual(disciplina, zanyatie.Disciplina); // Проверка дисциплины
            Assert.AreEqual(sotrudnik, zanyatie.Sotrudnik); // Проверка сотрудника
            Assert.AreEqual(auditoriya, zanyatie.Auditoriya); // Проверка аудитории
            Assert.AreEqual(gruppa, zanyatie.Gruppa); // Проверка группы
            Assert.AreEqual(para, zanyatie.Para); // Проверка пары
            Assert.AreEqual(vidZanyatiya, zanyatie.VidZanyatiya); // Проверка вида занятия
        }

        [TestMethod] // Атрибут, указывающий, что это метод с тестом
        public void Constructor_ShouldUseCurrentDateIfNoDateProvided()
        {
            // Arrange - подготовка данных для теста
            Disciplina disciplina = new Disciplina("Matematika", "Mat"); // Создание объекта дисциплины
            Sotrudnik sotrudnik = new Sotrudnik("Ivan", "Ivanov"); // Создание объекта сотрудника
            Auditoriya auditoriya = new Auditoriya("101"); // Создание объекта аудитории
            Gruppa gruppa = new Gruppa("Gruppa A", "GA", 30, 2023, "link", "boss"); // Создание объекта группы
            Para para = new Para(new DateTime(2024, 6, 1, 9, 0, 0), new DateTime(2024, 6, 1, 10, 30, 0), new DateTime(2024, 6, 1, 10, 30, 0), new DateTime(2024, 6, 1, 10, 45, 0)); // Создание объекта пары
            VidZanyatiya vidZanyatiya = new VidZanyatiya("Lektsiya"); // Создание объекта вида занятия

            // Act - выполнение тестируемого действия
            Zanyatie zanyatie = new Zanyatie(
                null, // Передаем null вместо даты
                disciplina,
                sotrudnik,
                auditoriya,
                gruppa,
                para,
                vidZanyatiya
            );

            // Assert - проверка результата
            Assert.AreEqual(DateTime.Now.Date, zanyatie.DataProvedeniya.Date); // Проверка, что дата установлена на текущую (только дата)
        }

        [TestMethod] // Атрибут, указывающий, что это метод с тестом
        public void Properties_ShouldGetAndSetValues()
        {
            // Arrange - подготовка данных для теста
            Zanyatie zanyatie = new Zanyatie(
                DateTime.Now,
                new Disciplina("Matematika", "Mat"),
                new Sotrudnik("Ivan", "Ivanov"),
                new Auditoriya("101"),
                new Gruppa("Gruppa A", "GA", 30, 2023, "link", "boss"),
                new Para(new DateTime(2024, 6, 1, 9, 0, 0), new DateTime(2024, 6, 1, 10, 30, 0), new DateTime(2024, 6, 1, 10, 30, 0), new DateTime(2024, 6, 1, 10, 45, 0)),
                new VidZanyatiya("Lektsiya")
            );

            // Новые значения для свойств
            DateTime newDate = new DateTime(2024, 7, 1);
            Disciplina newDisciplina = new Disciplina("Fizika", "Fiz");
            Sotrudnik newSotrudnik = new Sotrudnik("Petr", "Petrov");
            Auditoriya newAuditoriya = new Auditoriya("102");
            Gruppa newGruppa = new Gruppa("Gruppa B", "GB", 25, 2023, "newlink", "newboss");
            Para newPara = new Para(new DateTime(2024, 7, 1, 9, 0, 0), new DateTime(2024, 7, 1, 10, 30, 0), new DateTime(2024, 7, 1, 10, 30, 0), new DateTime(2024, 7, 1, 10, 45, 0));
            VidZanyatiya newVidZanyatiya = new VidZanyatiya("Seminar");

            // Act - установка новых значений свойств
            zanyatie.DataProvedeniya = newDate;
            zanyatie.Disciplina = newDisciplina;
            zanyatie.Sotrudnik = newSotrudnik;
            zanyatie.Auditoriya = newAuditoriya;
            zanyatie.Gruppa = newGruppa;
            zanyatie.Para = newPara;
            zanyatie.VidZanyatiya = newVidZanyatiya;

            // Assert - проверка результата
            Assert.AreEqual(newDate, zanyatie.DataProvedeniya); // Проверка нового значения даты проведения
            Assert.AreEqual(newDisciplina, zanyatie.Disciplina); // Проверка нового значения дисциплины
            Assert.AreEqual(newSotrudnik, zanyatie.Sotrudnik); // Проверка нового значения сотрудника
            Assert.AreEqual(newAuditoriya, zanyatie.Auditoriya); // Проверка нового значения аудитории
            Assert.AreEqual(newGruppa, zanyatie.Gruppa); // Проверка нового значения группы
            Assert.AreEqual(newPara, zanyatie.Para); // Проверка нового значения пары
            Assert.AreEqual(newVidZanyatiya, zanyatie.VidZanyatiya); // Проверка нового значения вида занятия
        }
    }
}
