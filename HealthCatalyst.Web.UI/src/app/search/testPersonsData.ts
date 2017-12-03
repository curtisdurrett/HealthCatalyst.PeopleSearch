import { PersonResult } from './model/PersonResult';

export function createTestPersons(): Array<PersonResult> {
  const persons = new Array<PersonResult>();
  persons.push(
    new PersonResult(
      'First Name1 Last Name1',
      'chess, cycling',
      1,
      '3309 Deleon Cir Belton TX 76513',
      'p1.jpg'
    )
  );
  persons.push(
    new PersonResult(
      'First Name2 Last Name2',
      'chess, cycling',
      2,
      '3309 Deleon Cir Belton TX 76513',
      'p2.jpg'
    )
  );
  persons.push(
    new PersonResult(
      'First Name3 Last Name3',
      'chess, cycling',
      3,
      '3309 Deleon Cir Belton TX 76513',
      'p3.jpg'
    )
  );
  persons.push(
    new PersonResult(
      'First Name4 Last Name4',
      'chess, cycling',
      4,
      '3309 Deleon Cir Belton TX 76513',
      'p4.jpg'
    )
  );
  persons.push(
    new PersonResult(
      'First Name5 Last Name5',
      'chess, cycling',
      5,
      '3309 Deleon Cir Belton TX 76513',
      'p5.jpg'
    )
  );
  persons.push(
    new PersonResult(
      'First Name6 Last Name6',
      'chess, cycling',
      6,
      '3309 Deleon Cir Belton TX 76513',
      'p6.jpg'
    )
  );
  persons.push(
    new PersonResult(
      'First Name7 Last Name7',
      'chess, cycling',
      7,
      '3309 Deleon Cir Belton TX 76513',
      'p7.jpg'
    )
  );
  persons.push(
    new PersonResult(
      'First Name8 Last Name8',
      'chess, cycling',
      8,
      '3309 Deleon Cir Belton TX 76513',
      'p8.jpg'
    )
  );
  persons.push(
    new PersonResult(
      'First Name9 Last Name9',
      'chess, cycling',
      9,
      '3309 Deleon Cir Belton TX 76513',
      'p9.jpg'
    )
  );
  persons.push(
    new PersonResult(
      'Satya Nadella',
      'Chess, Cycling',
      50,
      'Microsoft Corporation One Microsoft Way Redmond, WA 98052-6399',
      'p10.jpg'
    )
  );
  return persons;
}
