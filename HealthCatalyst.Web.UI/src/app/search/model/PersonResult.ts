export class PersonResult {
  name: string;
  interests: string;
  age: number;
  address: string;
  pictureFileName: string;
  constructor(
    name: string,
    interest: string,
    age: number,
    address: string,
    pictureFileName: string
  ) {
    this.name = name;
    this.interests = interest;
    this.age = age;
    this.address = address;
    this.pictureFileName = pictureFileName;
  }
}
