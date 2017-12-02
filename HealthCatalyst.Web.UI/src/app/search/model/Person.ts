export class Person {
  firstName: string;
  lastName: string;
  age: number;
  address: string;
  imagePath: string;
  constructor(firstName: string, lastName: string, age: number, address: string, imagePath: string) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.address = address;
    this.imagePath = imagePath;
  }
}
