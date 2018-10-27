import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class TaskService {

  constructor(private http: HttpClient) { }
  url='http://localhost:5000/api'

    /**
     * SendAnswerForValidation: PUT voor het antwoord te versturen naar de server
     * TODO: Frontend styling & testing
     */
    public SendAnswerForValidation(task:IPuzzleTask) {
        return this.http.put<ITaskValidation>(
            this.url+"/taskvalidation",
            task
            )
    }
    /**
     * GetPuzzleTask voor het verkrijgen van de puzzletask voor in te laden in de view.
     */
    public GetPuzzleTask(id:number) {
        return this.http.get<IPuzzleTask>(
            this.url+'/puzzle/'+id
        )
        
    }


}


//If you change these interfaces don't forget to change them in the backend as well!
export interface ITask
{
    id: number;
    title: string;
    description: string;
    district: IDistrict;
    districtID: number;
}
export interface IPuzzleTask 
{
    id: number;
    title: string;
    description: string;
    district: IDistrict;
    districtID: number;
    question: string;
    answer: string;
}
export interface IDistrict
{
    id: number;
    task: ITask;
    currentStateString: string;
}
export interface ITaskValidation
{
    isCorrect: boolean;
}