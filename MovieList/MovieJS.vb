Public Class MovieJS
    Public Property title() As String
        Get
            Return m_title
        End Get
        Set(value As String)
            m_title = value
        End Set
    End Property
    Private m_title As String
    Public Property year() As String
        Get
            Return m_year
        End Get
        Set(value As String)
            m_year = value
        End Set
    End Property
    Private m_year As String
    Public Property runtime() As String
        Get
            Return m_runtime
        End Get
        Set(value As String)
            m_runtime = value
        End Set
    End Property
    Private m_runtime As String
    Public Property genre() As String
        Get
            Return m_genre
        End Get
        Set(value As String)
            m_genre = value
        End Set
    End Property
    Private m_genre As String
    Public Property director() As String
        Get
            Return m_director
        End Get
        Set(value As String)
            m_director = value
        End Set
    End Property
    Private m_director As String
  
End Class
