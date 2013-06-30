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
    Public Property writer() As String
        Get
            Return m_writer
        End Get
        Set(value As String)
            m_writer = value
        End Set
    End Property
    Private m_writer As String
    Public Property actors() As String
        Get
            Return m_actors
        End Get
        Set(value As String)
            m_actors = value
        End Set
    End Property
    Private m_actors As String
    Public Property plot() As String
        Get
            Return m_plot
        End Get
        Set(value As String)
            m_plot = value
        End Set
    End Property
    Private m_plot As String
    Public Property poster() As String
        Get
            Return m_poster
        End Get
        Set(value As String)
            m_poster = value
        End Set
    End Property
    Private m_poster As String
    Public Property ttId() As String
        Get
            Return m_ttId
        End Get
        Set(value As String)
            m_ttId = value
        End Set
    End Property
    Private m_ttId As String

End Class
