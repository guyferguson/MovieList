MovieList.Models {

    Public Enum Genre
        {
        SCIFI = 0,
DRAMA = 1,
            HORROR = 2
            }
    End Enum


    Public Class MovieModel


        Public String Title { Get; Set; }
        Public String Year { Get; Set; }
        Public int Runtime { Get; Set; }
        Public List<Genre> Genres { Get; Set; }
        Public String Genres { Get; Set; }

    End Class
    }
End Namespace
