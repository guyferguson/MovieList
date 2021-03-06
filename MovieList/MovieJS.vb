﻿Public Class MovieJS
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

    Public Property update() As Boolean
        Get
            Return m_update
        End Get
        Set(value As Boolean)
            m_update = value
        End Set
    End Property
    Private m_update As Boolean
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
    Public Property type() As String
        Get
            Return m_type
        End Get
        Set(value As String)
            m_type = value
        End Set
    End Property
    Private m_type As String
    Public Property timesWatched() As String
        Get
            Return m_timesWatched
        End Get
        Set(value As String)
            m_timesWatched = value
        End Set
    End Property
    Private m_timesWatched As String
    Public Property discName() As String
        Get
            Return m_discName
        End Get
        Set(value As String)
            m_discName = value
        End Set
    End Property
    Private m_discName As String
    Public Property subtitles() As String
        Get
            Return m_subtitles
        End Get
        Set(value As String)
            m_subtitles = value
        End Set
    End Property
    Private m_subtitles As String
    Overrides Function ToString() As String
        Return ("Name: " & title)
    End Function
End Class
