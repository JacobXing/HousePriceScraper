# Generated by the gRPC Python protocol compiler plugin. DO NOT EDIT!
import grpc

import prediction_pb2 as prediction__pb2


class PredictionServiceStub(object):
  # missing associated documentation comment in .proto file
  pass

  def __init__(self, channel):
    """Constructor.

    Args:
      channel: A grpc.Channel.
    """
    self.FindNearestHouseIndices = channel.unary_unary(
        '/House.Prediction.PredictionService/FindNearestHouseIndices',
        request_serializer=prediction__pb2.PredictionRequest.SerializeToString,
        response_deserializer=prediction__pb2.PredictionResponse.FromString,
        )


class PredictionServiceServicer(object):
  # missing associated documentation comment in .proto file
  pass

  def FindNearestHouseIndices(self, request, context):
    """Find the indices of nearest houses
    """
    context.set_code(grpc.StatusCode.UNIMPLEMENTED)
    context.set_details('Method not implemented!')
    raise NotImplementedError('Method not implemented!')


def add_PredictionServiceServicer_to_server(servicer, server):
  rpc_method_handlers = {
      'FindNearestHouseIndices': grpc.unary_unary_rpc_method_handler(
          servicer.FindNearestHouseIndices,
          request_deserializer=prediction__pb2.PredictionRequest.FromString,
          response_serializer=prediction__pb2.PredictionResponse.SerializeToString,
      ),
  }
  generic_handler = grpc.method_handlers_generic_handler(
      'House.Prediction.PredictionService', rpc_method_handlers)
  server.add_generic_rpc_handlers((generic_handler,))
