import { Person } from './model/Person';

export function createTestPersons(): Array<Person> {
  const persons = new Array<Person>();
  persons.push(new Person('First Name1', 'Last Name1', 1, '3309 Deleon Cir Belton TX 76513', '1.jpg'));
  persons.push(new Person('First Name2', 'Last Name2', 2, '3309 Deleon Cir Belton TX 76513', '2.jpg'));
  persons.push(new Person('First Name3', 'Last Name3', 3, '3309 Deleon Cir Belton TX 76513', '3.jpg'));
  persons.push(new Person('First Name4', 'Last Name4', 4, '3309 Deleon Cir Belton TX 76513', '4.jpg'));
  persons.push(new Person('First Name5', 'Last Name5', 5, '3309 Deleon Cir Belton TX 76513', '4.jpg'));
  persons.push(new Person('First Name6', 'Last Name6', 6, '3309 Deleon Cir Belton TX 76513', '6.jpg'));
  persons.push(new Person('First Name7', 'Last Name7', 7, '3309 Deleon Cir Belton TX 76513', '7.jpg'));
  persons.push(new Person('First Name8', 'Last Name8', 8, '3309 Deleon Cir Belton TX 76513', '8.jpg'));
  return persons;
}
