export class Note{
  public id: number = -1;
  public name: string = "";
  public content: string = "";

  constructor(name?: string, content?: string) {
    this.name = name;
    this.content = content;
  }
}

export  class Country{
  public id: number = -1;
  public name: string = "";

  constructor(name?: string) {
    this.name = name;
  }
}
