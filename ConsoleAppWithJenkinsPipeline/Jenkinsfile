pipeline {
    agent any

    stages {
        stage('Restore') {
            steps {
                sh 'dotnet restore ConsoleAppWithJenkinsPipeline.sln'
		echo "Restored."
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build ConsoleAppWithJenkinsPipeline.sln --configuration Release'
		echo "Built."
            }
        }

        stage('Test') {
            steps {
                sh 'dotnet test ConsoleAppWithJenkinsPipeline.sln --no-build --configuration Release'
		cho "Tested."
            }
        }
    }

    post {
        always {
            echo "Pipeline finished."
        }
    }
}
