import { HttpContext, HttpHeaders, HttpParams } from '@angular/common/http';

export interface Options {
    headers?:
        | HttpHeaders
        | {
              [header: string]: string | string[];
          };
    observe?: 'body';
    context?: HttpContext;
    params?:
        | HttpParams
        | {
              [param: string]:
                  | string
                  | number
                  | boolean
                  | ReadonlyArray<string | number | boolean>;
          };
    reportProgress?: boolean;
    responseType?: 'json';
    withCredentials?: boolean;
    transferCache?:
        | {
              includeHeaders?: string[];
          }
        | boolean;
}

export interface Characters {
    items: Character[];
    page: number;
    totalPages: number;
    totalItems: number;
}

export interface Character {
    name: string;
    image: string;
    rating: number;
}

export interface PaginationParams {
    [param: string]:
        | string
        | number
        | boolean
        | ReadonlyArray<string | number | boolean>;
    page: number;
    perPage: number;
}
