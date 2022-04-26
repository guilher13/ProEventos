import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [];
  public eventosFiltrados: any = [];

  widthImg: number = 150;
  marginImg: number = 2;
  showImg: boolean = true;
  private _listFilter: string = '';

  public get listFilter(): string{
    return this._listFilter;
  }

  public set listFilter(value: string){
    this._listFilter = value;
    this.eventosFiltrados = this.listFilter ? this.EventFilter(this.listFilter) : this.eventos
  }

  EventFilter(listBy: string): any {
    listBy = listBy.toLowerCase();
    return this.eventos.filter(
      (      evento: { tema: string; local: string}) => evento.tema.toLowerCase().indexOf(listBy) !== -1 ||
             evento.local.toLowerCase().indexOf(listBy) !== -1      )
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {

    this.geEventos();
  }

  changeImg(){
    this.showImg = !this.showImg;
  }

  public geEventos(): void {
    this.http.get('https://localhost:5001/api/eventos').subscribe(
     response => {this.eventos = response;
    this.eventosFiltrados = this.eventos},
      error => console.log(error),
    );
  }

}
