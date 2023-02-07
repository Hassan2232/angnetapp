import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { ClientMessage } from 'src/Models/ClientMessage';
 
@Injectable()
export class DataService {
 
    private url = "/api/Clients";
 
    constructor(private http: HttpClient) {
    }
 
    getClients() {
        return this.http.get(this.url);
    }
     
    getClient(id: number) {
        return this.http.get(this.url + '/' + id);
    }
     
    createClient(ClientMessage: ClientMessage) {
        return this.http.post(this.url, ClientMessage);
    }
    updateClient(ClientMessage: ClientMessage) {
  
        return this.http.put(this.url, ClientMessage);
    }
    deleteClient(id: number) {
        return this.http.delete(this.url + '/' + id);
    }
}