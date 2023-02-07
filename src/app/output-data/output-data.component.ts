import { Component, OnInit } from '@angular/core';

import { ClientMessage } from 'src/Models/ClientMessage';
import {Router} from '@angular/router';
import { DataService } from '../data.service';

@Component({
  selector: 'app-output-data',
  templateUrl: './output-data.component.html',
  styleUrls: ['./output-data.component.css'],
  providers: [DataService],
})
export class OutputDataComponent implements OnInit {
  constructor(private dataService: DataService, private router: Router) { }

  ngOnInit(): void {
    this.loadData();
  }

  clientInfo: ClientMessage = new ClientMessage();

  loadData() {
    this.dataService.getClients()
      .subscribe((data: ClientMessage) => this.clientInfo = data);
  }

  oButt() {
    this.router.navigate(['']);
  }
}
