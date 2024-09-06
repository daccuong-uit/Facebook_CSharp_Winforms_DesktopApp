# Keypoint Detection using Triton Server

This repository demonstrates how to perform keypoint detection using Triton Inference Server. It processes images, sends them to the Triton server for inference, and detects keypoints based on the returned heatmaps.

## Prerequisites

Before running the client request script, ensure that you have the Triton Server running with the correct models loaded. You can use Docker to easily set up Triton Inference Server.

## Running Triton Server with Docker

To launch the Triton Inference Server, run the following Docker command:

```bash
docker run --gpus all --rm -p 8000:8000 -p 8001:8001 -p 8002:8002 \
-v E:/new_triton_server/tmp/triton_repo:/models \
nvcr.io/nvidia/tritonserver:23.09-py3 tritonserver --model-repository=/models
```

### Detailed Explanation:
- `--gpus all`: Allows the Docker container to use all available GPUs on the system.
- `--rm`: Automatically removes the container once it stops.
- `-p 8000:8000 -p 8001:8001 -p 8002:8002`: Maps the ports from the host machine to the container.
  - **8000**: For HTTP gRPC.
  - **8001**: For gRPC.
  - **8002**: For Prometheus metrics.
- `-v E:/new_triton_server/tmp/triton_repo:/models`:
  - `E:/new_triton_server/tmp/triton_repo`: Path on the host machine where your models are stored.
  - `/models`: Directory in the container where Triton Server will load models from.
- `nvcr.io/nvidia/tritonserver:23.09-py3`: Docker image of Triton Server, version 23.09 with Python 3.
- `--model-repository=/models`: Specifies the model repository directory in the container.

This command starts Triton Inference Server with models located in the `E:/new_triton_server/tmp/triton_repo` directory on the host machine, mapped to `/models` in the container.

## How to Use `client_request`

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/client_request.git
   ```

2. Navigate to the repository:
   ```bash
   cd client_request
   ```

3. Install the required dependencies:
   ```bash
   pip install -r requirements.txt
   ```

### Running the Client Script

The `client_request` script processes multiple images from a specified input folder, sends them to Triton Inference Server for inference, and outputs the results with detected keypoints. You can run the script with the following command:

```bash
python client_request.py --input_folder path/to/input/folder --output_folder path/to/output/folder --server_url your_triton_server_url --display_method opencv
```

#### Command Line Arguments:
- `--input_folder`: Path to the folder containing the input images (supports `.jpg`, `.jpeg`, `.png`).
- `--output_folder`: Path to the folder where the result images with keypoints will be saved.
- `--server_url`: URL of the Triton Inference Server (default is `localhost:8000`).
- `--display_method`: Choose between `opencv` or `matplotlib` to display the results. Default is `opencv`.

#### Example:

```bash
python client_request.py --input_folder ./images --output_folder ./results --server_url localhost:8000 --display_method matplotlib
```

This will:
- Process all images from the `./images` folder.
- Send them to Triton Server for inference.
- Save the result images with detected keypoints in the `./results` folder.
- Display the result images using `matplotlib`.

### Notes:
- Ensure that the Triton Server is running and the models are properly set up before running the client script.
- The output images will have the same names as the input images, appended with `_result`.
