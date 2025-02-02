abstract class Base {}

class Derived extends Base {}

class AnotherDerived extends Base {}

Base? foo(Base b) {
  return switch (b) {
    Derived _ => null,
    AnotherDerived _ => null,
    Base _ => null,
  };
}
