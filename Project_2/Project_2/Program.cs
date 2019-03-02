using System;
using System.Collections.Generic;

namespace PROJECT_2
{
    class Person
    {
        public string id;
        public string p_num;
        public string email;
        public string name;
        public string dep;

        public Person(string id, string name, string dep, string p_num, string email)
        {
            this.id = id;
            this.p_num = p_num;
            this.email = email;
            this.name = name;
            this.dep = dep;
        }
        public virtual void Personal_info()
        {
            Console.WriteLine();
            Console.Write("사번/학번: " + id + " 이름: " + name + " 학과/소속부서: " + dep + " 전화번호: " + p_num + " 이메일: " + email);
        }

    }

    class Student : Person
    {
        public string schoraship;
        public Student(string id, string name, string dep, string p_num, string email, string schoraship) : base(id, p_num, email, name, dep)
        {
            this.id = id;
            this.p_num = p_num;
            this.email = email;
            this.name = name;
            this.dep = dep;
            this.schoraship = schoraship;
        }
        public override void Personal_info()
        {
            base.Personal_info();
            Console.WriteLine();
            Console.Write("학번: " + id + " 이름: " + name + " 학과: " + dep + " 전화번호: " + p_num + " 이메일: " + email + "장학내역" + schoraship);
        }
    }

    class Faculty : Person
    {
        public string pay;
        public string date;
        public Faculty(string id, string p_num, string email, string name, string dep, string pay, string date) : base(id, p_num, email, name, dep)
        {
            this.id = id;
            this.p_num = p_num;
            this.email = email;
            this.name = name;
            this.dep = dep;
            this.pay = pay;
            this.date = date;
        }


    }

    class Professor : Faculty
    {
        public string position;
        public string subject;
        public Professor(string id, string dep, string position, string name, string subject, string p_num, string email, string date, string pay) : base(id, p_num, email, name, dep, pay, date)
        {
            this.id = id;
            this.p_num = p_num;
            this.email = email;
            this.name = name;
            this.dep = dep;
            this.position = position;
            this.subject = subject;
        }
        public new void Personal_info()
        {
            Console.Write("사번: " + id + " 소속학과: " + dep + "직급: " + position + " 이름: " + name + "강의과목: " + subject + " 전화번호: " + p_num + " 이메일: " + email + "입사일: " + date + "월급여: " + pay);
        }
       
    }
    
    class Staff : Faculty
    {
        public string position;

        public Staff(string id, string name, string dep, string position, string p_num, string email, string date, string pay) : base(id, p_num, email, name, dep, pay, date)
        {
            this.id = id;
            this.p_num = p_num;
            this.email = email;
            this.name = name;
            this.dep = dep;
            this.position = position;


        }
        public new void Personal_info()
        {
            Console.Write("사번: " + id + " 이름: " + name + " 소속부서: " + dep + "직급: " + position + " 전화번호: " + p_num + " 이메일: " + email + "입사일: " + date + "월급여: " + pay);
        }
    }

    class Assistant : Faculty
    {
        public string subject;
        public Assistant(string id, string dep, string name, string subject, string p_num, string email, string date, string pay) : base
            (id, p_num, email, name, dep, pay, date)
        {
            this.id = id;
            this.p_num = p_num;
            this.email = email;
            this.name = name;
            this.dep = dep;
            this.subject = subject;
        }
        public new void Personal_info()
        {
            Console.Write("사번: " + id + " 소속학과: " + dep + " 이름: " + name + "배당과목: " + subject + " 전화번호: " + p_num + " 이메일: " + email + "입사일: " + date + "월급여: " + pay);
        }
    }

    class Department
    {

    }

    class Subject
    {

    }

    public struct SubjectEnd
    {

    }

    class Program
    {
        private static IEnumerable<Person> list;

        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();

            person.Add(new Student("20150718", "김수지", "컴퓨터통신무인기술학과", "010-4164-2608", "oaosuzy95@naver.com", "임원장학금 1유형"));
            person.Add(new Professor("1234", "컴퓨터공학과", "교수", "이만희", ".net","010-1234-5678", "1234@hnu.kr", "18/5/24", "600"));



            //기본메뉴
            Console.WriteLine("\n");
            Console.WriteLine(" Hannam University Management System \n");
            Console.WriteLine("                                     \n");
            Console.WriteLine("       학번or사번을 입력하세요       \n"); 
            Console.Write("        >>");
            string id = Console.ReadLine();
           
            foreach (Person id_2 in list)
            {
                if (id_2 is Professor )//교수일때
                {
                    Console.WriteLine("교수메뉴");
                    Console.WriteLine("1.내정보변경");
                    Console.WriteLine("2.강의관리");
                    Console.WriteLine("메뉴를 선택하세요.");
                    int input = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case 1: //내정보 변경
                            Console.WriteLine("내정보변경");
                            Console.WriteLine("1. 이름\n");
                            Console.WriteLine("2. 학과\n");
                            Console.WriteLine("3. 전화번호\n");
                            Console.WriteLine("4. 이메일\n");
                            Console.Write("변경할 항목을 선택하세요 : ");
                            int input_2 = int.Parse(Console.ReadLine());

                            if (input_2 == 1)
                            {
                                Console.WriteLine("변경할 이름을 입력하세요");
                                Console.Write(">>");
                                string name = Console.ReadLine();
                                
                            }

                            if (input_2 == 2)
                            {
                                Console.WriteLine("변경할 학과를 입력하세요");
                                Console.Write(">>");
                                string dep = Console.ReadLine();
                            }

                            if (input_2 == 3)
                            {
                                Console.WriteLine("변경할 전화번호를 입력하세요");
                                Console.Write(">>");
                                string dep = Console.ReadLine();
                            }

                            if (input_2 == 4)
                            {
                                Console.WriteLine("변경할 이메일을 입력하세요");
                                Console.Write(">>");
                                string dep = Console.ReadLine();
                            }
                            break;

                        case 2: //강의관리
                            { }
                            break;
                    }
                }





                else if (id_2 is Student) //학생일때
                {
                    Console.WriteLine("");
                    Console.WriteLine("학생메뉴");
                    Console.WriteLine("1.내정보변경");
                    Console.WriteLine("2.수강관리");
                    Console.WriteLine("3.성적관리");
                    Console.Write("메뉴를 선택하세요.");
                    int input_1 = int.Parse(Console.ReadLine());

                    switch (input_1)
                    {
                        case 1: //내정보 변경
                            Console.WriteLine("내정보변경");
                            Console.WriteLine("1. 이름\n");
                            Console.WriteLine("2. 학과\n");
                            Console.WriteLine("3. 전화번호\n");
                            Console.WriteLine("4. 이메일\n");
                            Console.Write("변경할 항목을 선택하세요 : ");
                            int input_2 = int.Parse(Console.ReadLine());

                            if (input_2 == 1)
                            {
                                Console.WriteLine("변경할 이름을 입력하세요");
                                Console.Write(">>");
                                string name = Console.ReadLine();
                               
                            }

                            if (input_2 == 2)
                            {
                                Console.WriteLine("변경할 학과를 입력하세요");
                                Console.Write(">>");
                                string dep = Console.ReadLine();
                            }

                            if (input_2 == 3)
                            {
                                Console.WriteLine("변경할 전화번호를 입력하세요");
                                Console.Write(">>");
                                string dep = Console.ReadLine();
                            }

                            if (input_2 == 4)
                            {
                                Console.WriteLine("변경할 이메일을 입력하세요");
                                Console.Write(">>");
                                string dep = Console.ReadLine();
                            }
                            break;

                        case 2: //수강관리
                            { }
                            break;
                        case 3: //학점관리
                            { }
                            break;


                    }
                }



                }
            }
        }
    }



