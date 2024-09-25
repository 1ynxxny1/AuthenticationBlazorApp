# Movie Search Blazor Application - Authentication & Authorization

## Overview

This Blazor web application allows users to search movies using the OMDb API. Only authenticated users can access the movie search and details pages.

## Key Features

- **Movie Search**: Users search for movies by title, displaying results (Title, Year, Type, Poster).
- **Movie Details**: Clicking on a movie shows detailed information, including ratings.
- **Authentication**: Users must log in to access the search and details pages.

## OMDb API

- **Search Movies**:  
  `http://www.omdbapi.com/?s={movieTitle}&apikey=2a62c73`
- **Movie Details**:  
  `http://www.omdbapi.com/?i={imdbID}&apikey=2a62c73`

## User Authentication

### API Endpoints

- **Login**: `/api/User/login`
  - Request:  
    ```json
    { "email": "user@example.com", "password": "string" }
    ```
- **Register**: `/api/User/register`
  - Request:  
    ```json
    { "name": "string", "email": "user@example.com", "password": "string", "confirmPassword": "string" }
    ```

## JWT Authentication

1. **Login**: Users log in, receive a JWT token, which is stored client-side.
2. **Protected Routes**: Only logged-in users with a valid token can access the search and movie details pages.
3. **Logout**: Logging out clears the token.
